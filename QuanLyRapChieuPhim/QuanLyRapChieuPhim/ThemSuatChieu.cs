using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyRapChieuPhim
{
    public partial class ThemSuatChieu : Form
    {
        private DataTable data;
        public ThemSuatChieu()
        {
            InitializeComponent();
        }

        private void ThemSuatChieu_Load(object sender, EventArgs e)
        {
            string query = "select name from movie";
            data = DAL.DataProvider.ExecuteQuery(query);
            comboBoxFilm.DataSource = data;
            comboBoxFilm.DisplayMember = "name";

            const int firstHour = 0;
            const int lastHour = 24;
            for (var hour = firstHour; hour < lastHour; hour++)
            {
                for (var minute = 0; minute < 60; minute += 30)
                {
                    comboBoxHour.Items.Add($"{hour}:{minute:00}");
                }
            }
            comboBoxHour.Items.Add($"{lastHour}:00");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SuatChieu newSuatChieu = new SuatChieu();
            string query = $"select * from movie where name = N'{comboBoxFilm.GetItemText(comboBoxFilm.SelectedItem)}'";
            newSuatChieu.MovieID = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            newSuatChieu.GioChieu = comboBoxHour.GetItemText(comboBoxHour.SelectedItem);
            newSuatChieu.NgayChieu = ngaychieupicker.Value.Date;
            newSuatChieu.GioChieu = comboBoxHour.GetItemText(comboBoxHour.SelectedItem);
            newSuatChieu.PhongId = Convert.ToInt32(phongchieu.Text);
            newSuatChieu.Description = desc.Text;

            bool data = DAL.QuanLiSuatChieu.insertSuatChieu(newSuatChieu.MovieID, newSuatChieu.NgayChieu, newSuatChieu.PhongId, newSuatChieu.GioChieu, newSuatChieu.Description);
            if (data == true)
            {
                MessageBox.Show("Thêm suất chiếu thành công");
            }
            else
            {
                throw new Exception("Đã có lỗi xảy ra");
            }
        }
    }
}
