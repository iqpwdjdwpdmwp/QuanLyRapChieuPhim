using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;
using DTO;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class QuanLiPhim : UserControl
    {
        private DataTable data;
        Phim phim = new Phim();
        public int IDPHIM { get; set; }

        public QuanLiPhim()
        {
            InitializeComponent();
            getAllMovie();
        }
        private void getAllMovie()
        {
            data = DAL.QuanLiPhim.getAllMovie();
            danhsachphim.Rows.Clear();
            foreach(DataRow row in data.Rows)
            {
                phim.id = Convert.ToInt32(row["IDPHIM"]);
                phim.tenphim = row["TENPHIM"].ToString();
                phim.theloai = row["THELOAI"].ToString();
                phim.dangphim = row["DANGPHIM"].ToString();
                phim.quocgia = row["QUOCGIA"].ToString();
                phim.thoiluong = Convert.ToInt32(row["THOILUONG"]);
                phim.tacgia = row["TACGIA"].ToString();
                phim.mota = row["MOTA"].ToString();
                phim.namphathanh = row["NAMPHATHANH"].ToString();
                phim.moviePic = row["POSTER"].ToString();
                danhsachphim.Rows.Add(new object[]
                {
                    phim.id,
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            
            
            SuaPhim newForm = new SuaPhim(IDPHIM);
            newForm.Show();
        }

        private void danhsachphim_SelectionChanged(object sender, EventArgs e)
        {
            if(danhsachphim.SelectedRows.Count > 0)
            {
                int selectedrowindex = danhsachphim.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = danhsachphim.Rows[selectedrowindex];
                IDPHIM = Convert.ToInt32(selectedRow.Cells["IDPHIM"].Value);
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool data = DAL.QuanLiPhim.deleteMovie(IDPHIM);
                string img = phim.moviePic;
                File.Delete(img);
                MessageBox.Show("Xóa phim thành công"); // Sai logic xóa phim cần tìm path theo ID
            } catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAllMovie();
        }
    }
}
