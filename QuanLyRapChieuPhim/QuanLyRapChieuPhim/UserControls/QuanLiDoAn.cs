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

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class QuanLiDoAn : UserControl
    {
        string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\food_pictures\";

        public QuanLiDoAn()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            try
            {
                string path = Path.Combine(appPath, name.Text + ".jpg");
                Image img = guna2PictureBox1.Image;
                bool data = DAL.QuanLiDoAn.insertSanPham(name.Text, Convert.ToInt32(quantity.Text), Convert.ToInt32(price.Text), typelist.SelectedItem.ToString(), path);
                if(data == true)
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
                LoadData();
                img.Save(path);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void LoadData()
        {
            danhsachsanpham.Rows.Clear();
            DataTable data = new DataTable();
            data = DAL.QuanLiDoAn.getSanPham();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    danhsachsanpham.Rows.Add(new object[]
                    {
                        row["IDSP"].ToString(),
                        row["TENSP"].ToString(),
                        row["LOAISP"].ToString(),
                        row["SOLUONG"].ToString(),
                        row["GIATIEN"].ToString()
                    });
                }
            }
        }

        private void QuanLiDoAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select a picture";
            open.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
