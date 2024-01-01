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
        public int IDNV { get; set; }
        public NhanVien(int IDNV)
        {
            InitializeComponent();
            this.IDNV = IDNV;
        }


       //

        private void NhanVien_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string query = $"select * from taikhoan TK join nhanvien NV on TK.IDNV = NV.IDNV where TK.IDNV = {IDNV}";
            data = DAL.DataProvider.ExecuteQuery(query);

            tennhanvien.Text = data.Rows[0]["HOTEN"].ToString();
            chucvu.Text = data.Rows[0]["CHUCVU"].ToString();
            NV_Home newForm = new NV_Home();
            panel2.Controls.Add(newForm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            PhimDangChieu newForm = new PhimDangChieu(IDNV);
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
            DoAn newForm = new DoAn(IDNV);
            panel2.Controls.Add(newForm);
        }

        private void chucvu_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
