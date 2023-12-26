using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /*string path = Path.Combine(appPath, moviename.Text + ".jpg");
            Image img = moviepicture.Image;
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }*/
            //tạo account
            string query = $"SELECT MAX(IDACCOUNT) AS MaxID FROM TAIKHOAN";
            int temp=Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            int madn = 20230000 + temp+1;
            string tendn = "NV"+madn;
            
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
            int IDNV=Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            account.insertAccount(tendn, "12345678", pq, IDNV);
            //img.Save(path);
            MessageBox.Show("Thêm nhân viên thành công !!!");
        }
    }
}
