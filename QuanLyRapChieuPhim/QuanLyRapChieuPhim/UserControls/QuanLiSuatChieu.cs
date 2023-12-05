using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class QuanLiSuatChieu : UserControl
    {
        private DataTable data;
        public QuanLiSuatChieu()
        {
            InitializeComponent();
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getAllSuatChieu();
            getSuatChieuTheoPhong(newSuatChieu, data);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemSuatChieu newForm = new ThemSuatChieu();
            newForm.ShowDialog();
        }
        private void getSuatChieuTheoPhong(SuatChieu newSuatChieu, DataTable data)
        {
            suatchieudtgv.Rows.Clear();
            foreach(DataRow row in data.Rows)
            {
                newSuatChieu.MovieID = Convert.ToInt32(row["IDPHIM"]);
                newSuatChieu.NgayChieu = Convert.ToDateTime(row["NGAYCHIEU"]);
                newSuatChieu.PhongId = Convert.ToInt32(row["IDPHONG"]);
                newSuatChieu.GioChieu = row["THOIGIANCHIEU"].ToString();

                Object movieName = DAL.DataProvider.ExecuteScalar($"select TENPHIM from PHIM where IDPHIM = {newSuatChieu.MovieID} ");
                suatchieudtgv.Rows.Add(new object[]
                {
                    movieName.ToString(),
                    newSuatChieu.PhongId,
                    newSuatChieu.NgayChieu.ToString("dd/MM/yyyy"),
                    newSuatChieu.GioChieu,
                });
            }
        }

        private void suatchieudtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var movieid = DAL.DataProvider.ExecuteScalar($"select IDPHIM from PHIM where TENPHIM = N'{suatchieudtgv.Rows[e.RowIndex].Cells[0].Value}'");
            string gioChieu = suatchieudtgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            string ngayChieu = suatchieudtgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            ChiTiet newForm = new ChiTiet(Convert.ToInt32(movieid), gioChieu, ngayChieu);   
            newForm.ShowDialog();
        }


        private void phong1_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getSuatChieu(1);
            getSuatChieuTheoPhong(newSuatChieu, data);
        }

        private void tatca_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getAllSuatChieu();
            getSuatChieuTheoPhong(newSuatChieu,data);
        }

        private void phong2_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getSuatChieu(2);
            getSuatChieuTheoPhong(newSuatChieu, data);
        }

        private void phong3_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getSuatChieu(3);
            getSuatChieuTheoPhong(newSuatChieu, data);
        }

        private void phong4_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getSuatChieu(4);
            getSuatChieuTheoPhong(newSuatChieu, data);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            data = DAL.QuanLiSuatChieu.getAllSuatChieu();
            getSuatChieuTheoPhong(newSuatChieu, data);
        }
    }
}
