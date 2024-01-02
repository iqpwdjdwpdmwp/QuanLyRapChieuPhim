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
            danhsachtheloai.SelectedIndex = 0;
            danhsachquocgia.SelectedIndex = 0;
            danhsachthoiluong.SelectedIndex = 0;
            this.IDNV = IDNV;
        }

        private void PhimDangChieu_Load(object sender, EventArgs e)
        {


            datefinding.Value = DateTime.Today;
            string date = datefinding.Value.ToString();
            DataTable data = DAL.PhimDangChieu.getPhimDangChieu(date);
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
                list[i].list = DAL.PhimDangChieu.getIDPhimDangChieu();
                list[i].Description = data.Rows[i]["MOTA"].ToString();
                list[i].IDNV = IDNV;
                flowLayoutPanel1.Controls.Add(list[i]);
            }
        }

        private void datefinding_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void find_Click(object sender, EventArgs e)
        {
            string theloai = danhsachtheloai.SelectedItem.ToString();
            string quocgia = danhsachquocgia.SelectedItem.ToString();
            string date = datefinding.Value.ToString();
            int thoiluong = 0;
            //int thoiluong = Convert.ToInt32(danhsachthoiluong.SelectedItem);
            switch (danhsachthoiluong.SelectedItem.ToString())
            {
                case "Dưới 1 tiếng":
                    thoiluong = 60;
                    break;
                case "Dưới 2 tiếng":
                    thoiluong = 120;
                    break;
                case "Dưới 3 tiếng":
                    thoiluong = 180;
                    break;
                case "Dưới 4 tiếng":
                    thoiluong = 240;
                    break;
                default:
                    break;
            }
            DataTable data = DAL.PhimDangChieu.getPhimTheoPhanLoai(theloai, quocgia, thoiluong, date);
            LoadPhim(data);
        }
    }
}
