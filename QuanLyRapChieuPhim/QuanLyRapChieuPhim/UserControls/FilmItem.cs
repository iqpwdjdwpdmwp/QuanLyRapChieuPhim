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
    public partial class FilmItem : UserControl
    {
        string name;
       
        string propertiesFilm;
        string ngayChieu;
        string gioChieu;
        string description;
        int suatChieuID;
        int phong;
        Image image;
       
        public int IDPHIM { get; set; }
        public int IDNV { get; set; }
        public string Name { 
            get { return name; } set { name = value; tenphim.Text = value; }
        }
        public int SuatChieuID
        {
            get { return suatChieuID; }
            set { suatChieuID = value; }
        }
        public int Phong
        {
            get { return phong; }
            set { phong = value; }
        }
        public string NgayChieu
        {
            get { return ngayChieu; }
            set { ngayChieu = value;}
        }
        public string GioChieu
        {
            get { return gioChieu; }
            set { gioChieu = value; }
        }
        public string PropertiesFilm
        {
            get { return propertiesFilm; }
            set { propertiesFilm = value; properties.Text = value; }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                mota.Text = value;
            }
        }
        public Image Image
        {
            get { return image; }
            set { image = value; pictureBox1.Image = value; }
        }
        public FilmItem()
        {
            InitializeComponent();
        }

        private void FilmItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Name);
        }

       

        private void chitietbtn_Click(object sender, EventArgs e)
        {
            
            //NV_DatVe newForm = new NV_DatVe(Name, Phong, NgayChieu, GioChieu, Image, SuatChieuID);
            ChiTietPhim newForm = new ChiTietPhim(Name,Phong,NgayChieu,GioChieu,Image,SuatChieuID,IDPHIM, IDNV);
            newForm.ShowDialog();
        }
    }
}
