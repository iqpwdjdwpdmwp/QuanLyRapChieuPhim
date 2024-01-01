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
    public partial class KhoiPhucMatKhau : Form
    {
        string MaXacThuc;
        string TenDangNhap;
        string SqlConnection = @"Data Source=LAPTOP-VHDOE6SK\SQLEXPRESS;Initial Catalog=QUANLYSANPHAM;Integrated Security=True";
        SqlConnection sqlCon = null;
        public KhoiPhucMatKhau(string OTP, string TenDN)
        {
            InitializeComponent();
            MaXacThuc = OTP;
            TenDangNhap = TenDN;
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            HoanTat();
        }

        private void HoanTat()
        {
            if (tbMKNew.Text == "" || tbOTP.Text == "" || tbXacThucMK.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi hoàn tất", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbOTP.Text != MaXacThuc)
            {
                MessageBox.Show("Mã xác thực không chính xác,vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbOTP.Text = "";
                return;
            }
            if(tbMKNew.Text!=tbXacThucMK.Text)
            {
                MessageBox.Show("Xác thực mật khẩu không chính xác,vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbXacThucMK.Text = "";
                return;
            }
            //sau khi kiem tra het loi, cap nhat lai mk cho tai khoan can khoi phuc mk
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
                //lay mk moi
                string MatKhauNew = tbMKNew.Text;

                //tao doi tuong thuc thi truy van

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update TAIKHOAN SET MKHAU='" + MatKhauNew + "' WHERE TENDN='" + TenDangNhap + "'";
                //gui truy van vao ket noi
                cmd.Connection = sqlCon;
                //thuc thi
                int KetQua = cmd.ExecuteNonQuery();
                if (KetQua > 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }
            Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
