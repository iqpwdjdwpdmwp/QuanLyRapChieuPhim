using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class SuaPhim : Form
    {
        private int iDPHIM;
        private string OldImg { get; set; }
        string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\movie_pictures\";

        public int IDPHIM
        {
            get { return iDPHIM; }
            set { iDPHIM = value; }
        }

        public SuaPhim(int IDPHIM)
        {
            InitializeComponent();
            this.IDPHIM = IDPHIM;
        }

        private void SuaPhim_Load(object sender, EventArgs e)
        {

            DataTable data = DAL.QuanLiPhim.getMovieDetail(IDPHIM);
            foreach(DataRow row in data.Rows)
            {
                
                moviename.Text = row["TENPHIM"].ToString();
                moviegenre.Text = row["THELOAI"].ToString();
                movietype.Text = row["DANGPHIM"].ToString();
                moviecountry.Text = row["QUOCGIA"].ToString();
                movieduration.Text = row["THOILUONG"].ToString();
                tacgia.Text = row["TACGIA"].ToString();
                mota.Text = row["MOTA"].ToString();
                namphathanh.Text = row["NAMPHATHANH"].ToString();
                moviepicture.Image = Image.FromFile(row["POSTER"].ToString());
                OldImg = row["POSTER"].ToString();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            string path = Path.Combine(appPath, moviename.Text + ".jpg");
            Image img = moviepicture.Image;
            img.Save(path);
            img.Dispose();
            File.Delete(OldImg.ToString());

            try
            {
                bool data = DAL.QuanLiPhim.updateMovie(IDPHIM, moviename.Text, movietype.Text, moviegenre.Text, moviecountry.Text, path, movieduration.Text, mota.Text, tacgia.Text, namphathanh.Text);
                MessageBox.Show("Cập nhật phim thành công !!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private void moviepicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select a picture";
            open.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                moviepicture.Image = Image.FromFile(open.FileName);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
