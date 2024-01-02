using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyRapChieuPhim
{
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            AddNV();
        }

        private void AddNV()
        {
            //lay ngay bd, ngay sinh
            DateTime ngsinh= staffbirth.Value;
            DateTime ngBatDau = daystart.Value;   
            if(staffname.Text==""|| staffsex.Text == "" || staffgmail.Text == "" || staffphone.Text == "" || staffjob.Text == "" || staffname.Text == "" || staffbirth.Value.Date.ToString("dd/MM/yyyy")==""|| daystart.Value.Date.ToString("dd/MM/yyyy")=="")
            {
                MessageBox.Show("Bạn cần điền đủ dữ liệu trước khi hoàn tất", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(DateTime.Compare(ngsinh, ngBatDau) >=0)
            {
                MessageBox.Show("Ngày bắt đầu làm phải lớn hơn ngày sinh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isGmail = Regex.IsMatch(staffgmail.Text, @"^([a-zA-Z0-9_\-\.]+)@gmail\.com$");
            if(!isGmail)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng của email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //tạo account
            string query = $"SELECT MAX(IDACCOUNT) AS MaxID FROM TAIKHOAN";
            int temp = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            int madn = 20230000 + temp + 1;
            string tendn = "NV" + madn;

            int pq = 1;
            if (checkAdmin.Checked)
            {
                pq = 0;
            }
            Account account = new Account();
            query = $"SELECT MAX(IDNV) AS MaxID FROM NHANVIEN";
            QuanLiNhanVien quanLiNhanVien = new QuanLiNhanVien();
            string start = daystart.Value.Date.ToString("dd/MM/yyyy");
            string birth = staffbirth.Value.Date.ToString("dd/MM/yyyy");
            quanLiNhanVien.insertStaff(staffname.Text, staffsex.Text, staffgmail.Text, staffphone.Text, birth, staffjob.Text, start);
            int IDNV = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            account.insertAccount(tendn, "12345678", pq, IDNV);
            //img.Save(path);
            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel?", "Notification",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void ThemNV_Load(object sender, EventArgs e)
        {

        }
    }
}
