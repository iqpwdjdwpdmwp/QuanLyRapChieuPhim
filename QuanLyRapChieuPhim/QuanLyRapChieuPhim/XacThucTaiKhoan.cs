using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace QuanLyRapChieuPhim
{
    public partial class XacThucTaiKhoan : Form
    {
        Random random = new Random();
        int otp;
        string SqlConnection = @"Data Source=LAPTOP-VHDOE6SK\SQLEXPRESS;Initial Catalog=test123;Integrated Security=True";
        SqlConnection sqlCon = null;
        public XacThucTaiKhoan()
        {
            InitializeComponent();
        }

        private void btGuiMa_Click(object sender, EventArgs e)
        {
            
            GuiMa();
        }


        private void GuiMa()
        {
            if (tbTaiKhoan.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi ấn gửi mã", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Kiem tra xem tai khoan co ton tai hay khong 
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(SqlConnection);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                //lay tai khoan do nguoi dung nhap vao 
                string TaiKhoan = tbTaiKhoan.Text;
                //tao doi tuong thuc thi truy van 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from TAIKHOAN where TENDN='" + TaiKhoan + "'";
                //truyen ket noi de thuc thi truy van
                cmd.Connection = sqlCon;
                //bien nay dung de check xem tk,mk hop le hay k
                bool flag = false;
                //thuc thi 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    flag = true;
                }
                if (!flag)
                {
                    MessageBox.Show("Tài khoản không tồn tại, vui lòng kiểm tra lại thông tin của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbTaiKhoan.Text = "";
                    sqlCon.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }
            //Kiem tra xem email co ton tai hay khong 
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(SqlConnection);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                //lay email do nguoi dung nhap vao 
                string Email = tbEmail.Text;
                //tao doi tuong thuc thi truy van 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from NHANVIEN where EMAIL='"+Email+"'";
                //truyen ket noi de thuc thi truy van
                cmd.Connection = sqlCon;
                //bien nay dung de check xem tk,mk hop le hay k
                bool flag = false;
                //thuc thi 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    flag = true;
                }
                if (!flag)
                {
                    MessageBox.Show("Email không tồn tại, vui lòng kiểm tra lại Email mà bạn bạn đã cung cấp cho chúng tôi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbEmail.Text = "";
                    sqlCon.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }

            //sau khi check xem email,tk da ton tai thi tien hanh gui ma xac thuc
            otp = random.Next(100000, 1000000);
            string from, to, pass, content;
            from = "22520239@gm.uit.edu.vn";
            to = tbEmail.Text;
            pass = "1401148154";
            content = otp.ToString();
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Xác thực tài khoản";
            mail.Body = "Mã xác thực tài khoản của bạn là: " + otp.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);//from: gmail of sender; pass: password gmail of sender
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email sent successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhoiPhucMatKhau formKhoiPhucMatKhau = new KhoiPhucMatKhau(otp.ToString(), tbTaiKhoan.Text);
                formKhoiPhucMatKhau.ShowDialog();
                tbTaiKhoan.Text = tbEmail.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
