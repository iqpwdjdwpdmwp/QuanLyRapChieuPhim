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
using DAL;
namespace QuanLyRapChieuPhim
{
    public partial class ThemPhim : Form
    {
        string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\movie_pictures\";
        
        public ThemPhim()
        {
            InitializeComponent();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(appPath, moviename.Text + ".jpg");
            Image img = moviepicture.Image;
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            QuanLiPhim quanLiPhim = new QuanLiPhim();
            quanLiPhim.insertMovie(moviename.Text, movietype.Text, moviegenre.Text, moviecountry.Text, path, movieduration.Text, mota.Text, tacgia.Text, namphathanh.Text);
            img.Save(path);
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
