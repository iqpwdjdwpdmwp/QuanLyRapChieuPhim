using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DAL;
namespace QuanLyRapChieuPhim
{
    public partial class NV_DatVe : Form
    {
        int suatChieuID;
        
        public int SuatChieuID {
            get
            {
                return suatChieuID;
            }
            set
            {
                suatChieuID = value;
            }
        }
        

        ArrayList list = new ArrayList();
        public NV_DatVe(string name, int phongID,string ngayChieu, string gioChieu, Image image, int suatChieuID)
        {
            InitializeComponent();
            SuatChieuID = suatChieuID;
            load(name, phongID, ngayChieu, gioChieu, image, suatChieuID);
        }
        public void load(string name, int phongID, string ngayChieu, string gioChieu, Image image, int suatChieuID)
        {
            tenphim.Text = name;
            phong.Text = phongID.ToString();
            ngaychieu.Text = ngayChieu;
            giochieu.Text = gioChieu;
            pictureBox2.Image = image;

            DataTable data = DAL.Seat.getAllSeats(suatChieuID);
            int count = 0;
            
            List<string> list1 = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                list1.Add(row["MAGHE"].ToString());
            }
            for (int i = 65; i <= 72; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Button newBtn = new Button();
                    newBtn.Size = new Size(60, 60);
                    newBtn.Text = (char)i + j.ToString();
                    
                    bool seatState = true;
                    newBtn.Click += (sender, EventArgs) => { btn_Click(sender, EventArgs, ref seatState, list, ref count, list1); };
                    foreach (string item in list1)
                    {
                        if (newBtn.Text == item)
                        {
                            newBtn.BackColor = Color.FromArgb(255, 187, 187, 187);
                            newBtn.ForeColor = Color.White;
                        }
                    }
                    flpSeats.Controls.Add(newBtn);
                    
                }
            }
        }
        public void btn_Click(Object sender, EventArgs e, ref bool seatState, ArrayList list, ref int count, List<string> list1) {
            Button btn = (Button)sender;
            foreach(string item in list1)
            {
                if(btn.Text == item)
                {
                    MessageBox.Show("Ghế này đã có người đặt, vui lòng đặt ghế khác");
                    return;
                }
            }
            if (seatState == true)
            {
                ++count;
                list.Add(btn.Text);
                btn.BackColor = Color.FromArgb(255, 177, 21, 0);
                btn.ForeColor = Color.White;
            }
            else
            {
                --count;
                int index = list.IndexOf(btn.Text);
                list.RemoveAt(index);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            if (list.Count == 0)
            {
                ghe.Text = "Empty";
            }
            else
            {
                ghe.Text = string.Join(",", list.ToArray());
            }
            soluong.Text = count.ToString();
            seatState = !seatState;
            total.Text = (list.Count * 45000).ToString();
            total.Text += " VND";
        }

        private void thanhtoanbtn_Click(object sender, EventArgs e)
        {
            bool result = false;
            foreach(var item in list)
            {
                result = DAL.Seat.insertSeat(item.ToString(), suatChieuID, item.ToString()[0]);
            }
            if (result)
            {
                MessageBox.Show("Thanh toán thành công");
            } else
            {
                throw new Exception("Đã có lỗi");
            }
        }
    }
}
