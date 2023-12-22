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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }


        

        private void NhanVien_Load(object sender, EventArgs e)
        {
            NV_Home newForm = new NV_Home();
            panel2.Controls.Add(newForm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            PhimDangChieu newForm = new PhimDangChieu();
            panel2.Controls.Add(newForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            NV_Home newForm = new NV_Home();
            panel2.Controls.Add(newForm);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DoAn newForm = new DoAn();
            panel2.Controls.Add(newForm);
        }
    }
}
