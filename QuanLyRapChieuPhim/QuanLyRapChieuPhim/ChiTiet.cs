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

namespace QuanLyRapChieuPhim
{
    public partial class ChiTiet : Form
    {
        string gioChieu;
        int movieId;
        string ngayChieu;
        int idSuatChieu;

        public int IDSuatChieu
        {
            get { return idSuatChieu; }
            set { idSuatChieu = value;}
        }

        public ChiTiet(int movieId, string gioChieu, string ngayChieu)
        {
            InitializeComponent();
            this.gioChieu = gioChieu;
            this.movieId = movieId;
            this.ngayChieu = ngayChieu;
            getInfo(this.movieId);
            loadSeat();
        }
        public void getInfo(int movieid)
        {
            string query = $"select * from suatchieu where IDPHIM = {movieid}";
            DataTable data = DAL.DataProvider.ExecuteQuery(query);
            string name = DAL.DataProvider.ExecuteScalar($"select TENPHIM from PHIM where IDPHIM = {movieid}").ToString();
            string ngayChieu = string.Empty;
            int phongChieu = -1;
            foreach(DataRow row in data.Rows)
            {
                // ngayChieu = Convert.ToDateTime(row["NGAYCHIEU"]).ToString("dd/MM/yyyy");
                ngayChieu = row["NGAYCHIEU"].ToString();
                phongChieu = Convert.ToInt32(row["IDPHONG"]);
            }
            tenphim.Text = name;
            ngaychieu.Text = ngayChieu;
            suatchieu.Text = gioChieu;
        }
        public void loadSeat()
        {
            flpSeats.Controls.Clear();
            var ID = DAL.DataProvider.ExecuteScalar($"select IDSUATCHIEU from SUATCHIEU where THOIGIANCHIEU = '{gioChieu}' and NGAYCHIEU = '{(Convert.ToDateTime(ngayChieu)).ToString("yyyy/dd/MM")}'");
            IDSuatChieu = Convert.ToInt32(ID);
            DataTable data = DAL.Seat.getAllSeats(Convert.ToInt32(ID));
            //if (data.Rows.Count == 0)
            //{
            //    MessageBox.Show(gioChieu);
            //    for (int i = 65; i <= 72; i++)
            //    {
            //        for (int j = 1; j <= 9; j++)
            //        {
            //            DTO.Seat seat = new DTO.Seat();
            //            seat.Name = (char)i + j.ToString();
            //            seat.SuatChieu_ID = Convert.ToInt32(suatChieuID);
            //            seat.ConTrong = 0;
            //            DAL.Seat.insertSeat(seat.Name, seat.SuatChieu_ID);
            //        }
            //    }
            //    data = DAL.Seat.getAllSeats(Convert.ToInt32(suatChieuID));

            //    foreach (DataRow row in data.Rows)
            //    {
            //        Button newBtn = new Button();
            //        newBtn.Size = new Size(54, 54);
            //        newBtn.Text = row["name"].ToString();
            //        flpSeats.Controls.Add(newBtn);
            //        if (Convert.ToInt32(row["controng"]) == 1)
            //        {
            //            newBtn.BackColor = Color.FromArgb(255, 187, 187, 187);
            //            newBtn.BackColor = Color.White;
            //        }
            //    }
            //} else
            //{
            //    foreach (DataRow row in data.Rows)
            //    {
            //        Button newBtn = new Button();
            //        newBtn.Size = new Size(54, 54);
            //        newBtn.Text = row["name"].ToString();
            //        bool seatState = true;
            //        newBtn.Click += (sender,EventArgs) => { btn_Click(sender, EventArgs, ref seatState); };
            //        flpSeats.Controls.Add(newBtn);
            //        if (Convert.ToInt32(row["controng"]) == 1)
            //        {
            //            newBtn.BackColor = Color.FromArgb(255, 187, 187, 187);
            //            newBtn.BackColor = Color.White;
            //        }
            //    }
            //}
            List<string> list = new List<string>();
            foreach(DataRow row in data.Rows)
            {
                list.Add(row["MAGHE"].ToString());
            }

            for (int i = 65; i <= 72; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Button newBtn = new Button();
                    newBtn.Size = new Size(54, 54);
                    newBtn.Text = (char)i + j.ToString();
                    foreach(string item in list)
                    {
                        if(newBtn.Text == item)
                        {
                            newBtn.BackColor = Color.FromArgb(255, 187, 187, 187);
                            newBtn.ForeColor = Color.White;
                        }
                    }
                    flpSeats.Controls.Add(newBtn);
                }
            }
        }
        public void btn_Click(object sender, EventArgs e, ref bool seatState)
        {
            Button btn = (Button)sender;
            if(seatState == true)
            {
                btn.BackColor = Color.FromArgb(255, 177, 21, 0);
                btn.ForeColor = Color.White;
            } else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            seatState = !seatState;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IDSuatChieu.ToString());
            bool data = DAL.QuanLiSuatChieu.deleteSuatChieu(IDSuatChieu);
            if (data == true)
            {
                MessageBox.Show("Xóa suất chiếu thành công");
            }
            
        }
    }
}
