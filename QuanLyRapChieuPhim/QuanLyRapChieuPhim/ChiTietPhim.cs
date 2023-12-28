using Guna.UI2.WinForms;
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
    public partial class ChiTietPhim : Form
    {
        private bool isClick = false;
        public string Name { get; set; }
        
        public int Phong { get; set; }
        public string NgayChieu { get; set; }
        public string GioChieu { get; set; }
        public Image Image { get; set; }
        public int SuatChieuID { get; set; }
        public int IDPHIM { get; set; }
        public int IDNV { get; set; }
        DataTable list;
        public ChiTietPhim(string Name, int Phong, string NgayChieu, string GioChieu, Image Image, int SuatChieuID, int IDPHIM, int IDNV, DataTable list)
        {
            InitializeComponent();
            this.Name = Name;
            this.Phong = Phong;
            this.NgayChieu = NgayChieu;
            this.GioChieu = GioChieu;
            this.Image = Image;
            this.SuatChieuID = SuatChieuID;
            this.IDPHIM = IDPHIM;
            this.IDNV = IDNV;
            this.list = list;
        }


        private void ChiTietPhim_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = DAL.QuanLiPhim.getChiTietPhim(IDPHIM);
            if(data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    poster.Image = Image.FromFile(row["POSTER"].ToString());
                    name.Text = row["TENPHIM"].ToString();
                    director.Text = row["TACGIA"].ToString();
                    country.Text = row["QUOCGIA"].ToString();
                    description.Text = row["MOTA"].ToString();
                    year.Text = row["NAMPHATHANH"].ToString();
                    duration.Text = row["THOILUONG"].ToString() + " Phút";
                }
            }

            data = DAL.QuanLiSuatChieu.getSuatChieuTheoID(IDPHIM);
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Size = new Size(50, 50);
                    btn.Text = row["THOIGIANCHIEU"].ToString();
                    btn.Cursor = Cursors.Hand;
                    btn.Click += btn_Click;
                    btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    btn.CheckedState.FillColor = Color.FromArgb(255, 172, 27, 27);
                    btn.FillColor = Color.Transparent;
                    btn.BorderColor = Color.FromArgb(255, 172, 27, 27);
                    btn.BorderThickness = 1;
                    btn.Margin = new Padding(0,0,15,0);
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }
        private void datvebtn_Click(object sender, EventArgs e)
        {
            if(isClick == false)
            {
                MessageBox.Show("Bạn chưa chọn giờ chiếu, vui lòng thử lại");
                return;
            } else
            {
                NV_DatVe newForm = new NV_DatVe(Name, Phong, NgayChieu, GioChieu, Image, SuatChieuID, IDNV, IDPHIM);
                newForm.ShowDialog();
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            string today = DateTime.Today.ToString();
            DataTable data = new DataTable();
            data = DAL.DataProvider.ExecuteQuery($"select * from SUATCHIEU where NGAYCHIEU = '{today}' and THOIGIANCHIEU = '{button.Text}'");
            this.Phong = Convert.ToInt32(data.Rows[0]["IDPHONG"]);
            this.GioChieu = data.Rows[0]["THOIGIANCHIEU"].ToString();
            isClick = true;
        }
    }
}
