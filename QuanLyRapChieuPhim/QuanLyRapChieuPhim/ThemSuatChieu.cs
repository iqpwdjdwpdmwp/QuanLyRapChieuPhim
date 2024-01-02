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
            string query = "select TENPHIM from PHIM";
            data = DAL.DataProvider.ExecuteQuery(query);
            comboBoxFilm.DataSource = data;
            comboBoxFilm.DisplayMember = "TENPHIM";

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
            List<string> list = new List<string>();
            SuatChieu newSuatChieu = new SuatChieu();
            string query = $"select * from PHIM where TENPHIM = N'{comboBoxFilm.GetItemText(comboBoxFilm.SelectedItem)}'";
            newSuatChieu.MovieID = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));

            newSuatChieu.NgayChieu = ngaychieupicker.Value.Date;
            newSuatChieu.GioChieu = comboBoxHour.GetItemText(comboBoxHour.SelectedItem);
            newSuatChieu.PhongId = Convert.ToInt32(phongchieu.Text);
            query = $"select top 1 THOIGIANCHIEU from SUATCHIEU where NGAYCHIEU = '{newSuatChieu.NgayChieu}' and THOIGIANCHIEU <= '{newSuatChieu.GioChieu}' and IDPHONG = {newSuatChieu.PhongId} ORDER BY THOIGIANCHIEU DESC";
            DataTable temp = DAL.DataProvider.ExecuteQuery(query);

            if(temp.Rows.Count > 0)
            {
                
                string suatChieuGanNhatVoiSuatChieuDuocChon = temp.Rows[0]["THOIGIANCHIEU"].ToString();
                query = $"select top 1 THOILUONG from PHIM P inner join SUATCHIEU SC on P.IDPHIM = SC.IDPHIM where SC.THOIGIANCHIEU = '{suatChieuGanNhatVoiSuatChieuDuocChon}' and SC.NGAYCHIEU = '{newSuatChieu.NgayChieu}' and IDPHONG = {newSuatChieu.PhongId}";
                int duration = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query)); // 203
                int hour = duration / 60; // 3
                int minute = duration % 60; // 23
                int suatChieuGanNhatHour = Convert.ToInt32(suatChieuGanNhatVoiSuatChieuDuocChon.Split(':')[0]);
                int suatChieuGanNhatMinute = Convert.ToInt32(suatChieuGanNhatVoiSuatChieuDuocChon.Split(':')[1]);
                suatChieuGanNhatHour += hour;
                suatChieuGanNhatMinute += minute;

                if (suatChieuGanNhatMinute >= 60)
                {
                    suatChieuGanNhatHour += suatChieuGanNhatMinute / 60;
                    suatChieuGanNhatMinute %= 60;
                }

                int newSuatChieuHour = Convert.ToInt32(newSuatChieu.GioChieu.Split(':')[0]);
                int newSuatChieuMinute = Convert.ToInt32(newSuatChieu.GioChieu.Split(':')[1]);
                MessageBox.Show(newSuatChieuHour.ToString());
                if (newSuatChieuHour > suatChieuGanNhatHour || newSuatChieuHour == suatChieuGanNhatHour && newSuatChieuMinute > suatChieuGanNhatMinute)
                    
                {
                    bool data = DAL.QuanLiSuatChieu.insertSuatChieu(newSuatChieu.MovieID, newSuatChieu.NgayChieu, newSuatChieu.PhongId, newSuatChieu.GioChieu);
                    if (data == true)
                    {
                        MessageBox.Show("Thêm suất chiếu thành công");
                    }
                    else
                    {
                        throw new Exception("Đã có lỗi xảy ra");
                    }
                }
                else
                {
                    MessageBox.Show("Phòng này hiện tại không còn trống, vui lòng chọn phòng khác hoặc thời gian khác!");
                }
            }
            else
            {
            MessageBox.Show(newSuatChieu.NgayChieu.ToString());
                bool data = DAL.QuanLiSuatChieu.insertSuatChieu(newSuatChieu.MovieID, newSuatChieu.NgayChieu, newSuatChieu.PhongId, newSuatChieu.GioChieu);
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
}
