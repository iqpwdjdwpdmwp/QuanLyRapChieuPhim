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
        public PhimDangChieu()
        {
            InitializeComponent();
        }

        private void PhimDangChieu_Load(object sender, EventArgs e)
        {
            DataTable data = DAL.PhimDangChieu.getPhimDangChieu();
            FilmItem[] list = new FilmItem[100];
            for(int i = 0; i < data.Rows.Count; i++)
            {
                list[i] = new FilmItem();
                list[i].Name = data.Rows[i]["name"].ToString();
                string s = data.Rows[i]["type"].ToString() + data.Rows[i]["genre"].ToString();
                list[i].PropertiesFilm = s;
                list[i].Image = Image.FromFile(data.Rows[i]["moviepic"].ToString());
                list[i].NgayChieu = Convert.ToDateTime(data.Rows[i]["ngaychieu"]).ToString("dd/MM/yyyy");
                list[i].GioChieu = data.Rows[i]["giochieu"].ToString();
                list[i].Phong = Convert.ToInt32(data.Rows[i]["phongid"]);
                list[i].SuatChieuID = Convert.ToInt32(data.Rows[i]["id"]);
                flowLayoutPanel1.Controls.Add(list[i]);
            }

        }
    }
}
