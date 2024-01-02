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

namespace QuanLyRapChieuPhim
{
    public partial class Login : Form
    {
        string SqlConnection = @"Data Source=LAPTOP-VHDOE6SK\SQLEXPRESS;Initial Catalog=test123;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Login()
        {
            InitializeComponent();
            
            
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            if (tbTaiKhoan.Text == "" || tbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi đăng nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                //lay tk,mk do nguoi dung nhap vao 
                string TaiKhoan = tbTaiKhoan.Text;
                string MatKhau = tbMatKhau.Text;
                //tao doi tuong thuc thi truy van 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *from TAIKHOAN where TENDN='" + TaiKhoan + "'and MKHAU='" + MatKhau + "'";
                //truyen ket noi de thuc thi truy van
                cmd.Connection = sqlCon;
                //bien nay dung de check xem tk,mk hop le hay k
                bool flag = false;
                //thuc thi 
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    flag = true;
                    if (reader.GetInt32(3) == 1)
                    {
                        string query = $"SELECT IDNV FROM TAIKHOAN WHERE TENDN = '{TaiKhoan}'";
                        int IDNV = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
                        NhanVien nv = new NhanVien(IDNV);
                        this.Hide();
                        nv.ShowDialog();
                        tbMatKhau.Text = tbTaiKhoan.Text = "";
                        this.Show();
                    }
                    if (reader.GetInt32(3) == 0)
                    {
                        Admin admin = new Admin();
                        this.Hide();
                        admin.ShowDialog();
                        tbMatKhau.Text = tbTaiKhoan.Text = "";
                        this.Show();
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMatKhau.Text = tbTaiKhoan.Text = "";
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
        }

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacThucTaiKhoan xacThucTaiKhoan = new XacThucTaiKhoan();
            xacThucTaiKhoan.ShowDialog();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
