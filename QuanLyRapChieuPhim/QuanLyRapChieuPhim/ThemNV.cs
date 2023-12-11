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
            string start = daystart.Value.Date.ToString("dd/MM/yyyy");
            string birth = staffbirth.Value.Date.ToString("dd/MM/yyyy");
            QuanLiNhanVien quanLiNhanVien = new QuanLiNhanVien();
            quanLiNhanVien.insertStaff(staffname.Text, staffsex.Text, staffgmail.Text, staffphone.Text, birth, staffjob.Text, start);
            //img.Save(path);
            //tạo account
            /*string t=staffgmail.Text;
            string tendn = "20230";
            for(int i=0;i<4;i++)
            {
                tendn = tendn + t[i];
            }
            int pq=0;
            if(checkAdmin.Checked)
            {
                pq = 1;
            }    
            Account account = new Account();
            account.insertAccount(t,"12345678",pq);*/
        }
    }
}
