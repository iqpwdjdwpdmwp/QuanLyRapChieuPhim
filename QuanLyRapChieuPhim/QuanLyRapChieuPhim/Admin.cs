using QuanLyRapChieuPhim.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            ThongKe newForm = new ThongKe();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            QuanLiPhim newForm = new QuanLiPhim();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLiSuatChieu newForm = new QuanLiSuatChieu();
            panel2.Controls.Clear();
            panel2.Controls.Add((newForm));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            QuanLiDoAn newForm = new QuanLiDoAn();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKe newForm = new ThongKe();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLiNhanVien newForm = new QuanLiNhanVien();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LichSuGiaoDich newForm = new LichSuGiaoDich();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
