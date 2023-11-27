using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class QuanLiPhim : UserControl
    {
        private DataTable data;


       
        public QuanLiPhim()
        {
            InitializeComponent();
            getAllMovie();
        }
        private void getAllMovie()
        {
            Phim phim = new Phim();
            data = DAL.QuanLiPhim.getAllMovie();
            foreach(DataRow row in data.Rows)
            {
                phim.id = Convert.ToInt32(row["id"]);
                phim.name = row["name"].ToString();
                phim.type = row["type"].ToString();
                phim.genre = row["genre"].ToString();
                phim.country = row["country"].ToString();
                phim.duration = Convert.ToInt32(row["duration"]);
                guna2DataGridView1.Rows.Add(new object[]
                {
                    phim.id,
                    phim.name,
                    phim.type,
                    phim.genre,
                    phim.country,
                    phim.duration
                });
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemPhim newForm = new ThemPhim();
            newForm.Show();
        }
    }
}
