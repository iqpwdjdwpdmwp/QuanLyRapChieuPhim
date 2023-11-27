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
        public ChiTiet(int movieid, string gioChieu)
        {
            InitializeComponent();
            this.gioChieu = gioChieu;
            getInfo(movieid);
            loadSeat();
        }
        public void getInfo(int movieid)
        {
            string query = $"select * from suatchieu where movieid = {movieid}";
            DataTable data = DAL.DataProvider.ExecuteQuery(query);
            string name = DAL.DataProvider.ExecuteScalar($"select name from movie where id = {movieid}").ToString();
            string ngayChieu = string.Empty;
            int phongChieu = -1;
            foreach(DataRow row in data.Rows)
            {
                ngayChieu = Convert.ToDateTime(row["ngaychieu"]).ToString("dd/MM/yyyy");
                phongChieu = Convert.ToInt32(row["phongid"]);
            }
            tenphim.Text = name;
            ngaychieu.Text = ngayChieu;
            suatchieu.Text = gioChieu;
        }
        public void loadSeat()
        {
            flpSeats.Controls.Clear();
            var suatChieuID = DAL.DataProvider.ExecuteScalar($"select id from suatchieu where giochieu = '{gioChieu}'");
            DataTable data = DAL.Seat.getAllSeats(Convert.ToInt32(suatChieuID));
            if (data.Rows.Count == 0)
            {
                MessageBox.Show(gioChieu);
                for (int i = 65; i <= 72; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        DTO.Seat seat = new DTO.Seat();
                        seat.Name = (char)i + j.ToString();
                        seat.SuatChieu_ID = Convert.ToInt32(suatChieuID);
                        seat.ConTrong = 0;
                        DAL.Seat.insertSeat(seat.Name, seat.SuatChieu_ID);
                    }
                }
                data = DAL.Seat.getAllSeats(Convert.ToInt32(suatChieuID));

                foreach (DataRow row in data.Rows)
                {
                    Button newBtn = new Button();
                    newBtn.Size = new Size(54, 54);
                    newBtn.Text = row["name"].ToString();
                    flpSeats.Controls.Add(newBtn);
                    if (Convert.ToInt32(row["controng"]) == 1)
                    {
                        newBtn.BackColor = Color.FromArgb(255, 187, 187, 187);
                        newBtn.BackColor = Color.White;
                    }
                }
            } else
            {
                foreach (DataRow row in data.Rows)
                {
                    Button newBtn = new Button();
                    newBtn.Size = new Size(54, 54);
                    newBtn.Text = row["name"].ToString();
                    bool seatState = true;
                    newBtn.Click += (sender,EventArgs) => { btn_Click(sender, EventArgs, ref seatState); };
                    flpSeats.Controls.Add(newBtn);
                    if (Convert.ToInt32(row["controng"]) == 1)
                    {
                        newBtn.BackColor = Color.FromArgb(255, 187, 187, 187);
                        newBtn.BackColor = Color.White;
                    }
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

    }
}
