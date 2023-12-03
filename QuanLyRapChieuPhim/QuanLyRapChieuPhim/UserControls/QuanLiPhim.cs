using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class QuanLiPhim : UserControl
    {
        private DataTable data;


       
        public QuanLiPhim()
        {
            InitializeComponent();
            getAllMovie();
        }
        private void getAllMovie()
        {
            Phim phim = new Phim();
            data = DAL.QuanLiPhim.getAllMovie();
            foreach(DataRow row in data.Rows)
            {
                phim.id = Convert.ToInt32(row["IDPHIM"]);
                phim.tenphim = row["TENPHIM"].ToString();
                phim.theloai = row["THELOAI"].ToString();
                phim.dangphim = row["DANGPHIM"].ToString();
                phim.quocgia = row["QUOCGIA"].ToString();
                phim.thoiluong = Convert.ToInt32(row["THOILUONG"]);
                guna2DataGridView1.Rows.Add(new object[]
                {
                    phim.tenphim,
                    phim.dangphim,
                    phim.quocgia,
                    phim.theloai,
                    phim.thoiluong
                });
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemPhim newForm = new ThemPhim();
            newForm.Show();
        }
    }
}
