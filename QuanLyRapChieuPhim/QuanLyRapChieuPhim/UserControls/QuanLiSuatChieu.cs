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
                newSuatChieu.MovieID = Convert.ToInt32(row["movieid"]);
                newSuatChieu.NgayChieu = Convert.ToDateTime(row["ngaychieu"]);
                newSuatChieu.PhongId = Convert.ToInt32(row["phongid"]);
                newSuatChieu.GioChieu = row["giochieu"].ToString();
                newSuatChieu.Description = row["description"].ToString();

                Object movieName = DAL.DataProvider.ExecuteScalar($"select name from movie where id = {newSuatChieu.MovieID} ");
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

            var movieid = DAL.DataProvider.ExecuteScalar($"select id from movie where name = N'{suatchieudtgv.Rows[e.RowIndex].Cells[0].Value}'");
            string gioChieu = suatchieudtgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            ChiTiet newForm = new ChiTiet(Convert.ToInt32(movieid), gioChieu);   
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
    }
}
