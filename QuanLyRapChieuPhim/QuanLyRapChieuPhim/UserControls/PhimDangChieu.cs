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

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class PhimDangChieu : UserControl
    {
        public int IDNV { get; set; }
        public PhimDangChieu(int IDNV)
        {
            InitializeComponent();
            this.IDNV = IDNV;
        }

        private void PhimDangChieu_Load(object sender, EventArgs e)
        {
            danhsachtheloai.Text = "Tất cả";
            DataTable data = DAL.PhimDangChieu.getPhimDangChieu();
            LoadPhim(data);

        }

        private void danhsachtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theloai = danhsachtheloai.SelectedItem.ToString();
            DataTable data = DAL.PhimDangChieu.getPhimTheoTheLoai(theloai);
            LoadPhim(data);
        }
        private void LoadPhim(DataTable data)
        {
            flowLayoutPanel1.Controls.Clear();
            FilmItem[] list = new FilmItem[100];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                int hour = Convert.ToInt32(data.Rows[i]["THOILUONG"]) / 60;
                int minute = Convert.ToInt32(data.Rows[i]["THOILUONG"]) % 60;
                list[i] = new FilmItem();
                list[i].IDPHIM = Convert.ToInt32(data.Rows[i]["IDPHIM"]);
                list[i].Name = data.Rows[i]["TENPHIM"].ToString();
                string s = data.Rows[i]["DANGPHIM"].ToString() + " | " + hour.ToString() + "h " + minute.ToString() +"min" + " | " +data.Rows[i]["THELOAI"].ToString();
                list[i].PropertiesFilm = s;
                list[i].Image = Image.FromFile(data.Rows[i]["POSTER"].ToString());
                list[i].NgayChieu = Convert.ToDateTime(data.Rows[i]["NGAYCHIEU"]).ToString("dd/MM/yyyy");
                //list[i].GioChieu = data.Rows[i]["THOIGIANCHIEU"].ToString();
                list[i].Phong = Convert.ToInt32(data.Rows[i]["IDPHONG"]);
                list[i].SuatChieuID = Convert.ToInt32(data.Rows[i]["IDSUATCHIEU"]);
                list[i].Description = data.Rows[i]["MOTA"].ToString();
                list[i].IDNV = IDNV;
                flowLayoutPanel1.Controls.Add(list[i]);
            }
        }
    }
}
