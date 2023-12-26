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
    public partial class DoAn : UserControl
    {
        public int IDNV { get; set; }
        public DoAn(int IDNV)
        {
            InitializeComponent();
            this.IDNV = IDNV;
        }

        private void DoAn_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCart();
            
        }
        private void LoadData()
        {
            DAL.QuanLiDoAn.clearCart();
            
            DataTable data = new DataTable();
            data = DAL.QuanLiDoAn.getSanPham();
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    FoodItem item = new FoodItem(cart,totalprice,totalquantity);
                    item.ID = Convert.ToInt32(row["IDSP"]);
                    item.Name = row["TENSP"].ToString();
                    item.Price = Convert.ToInt32(row["GIATIEN"]);
                    item.Quantity = Convert.ToInt32(row["SOLUONG"]);
                    item.Img = Image.FromFile(row["PICTURE"].ToString());
                    flowLayoutPanel1.Controls.Add(item);
                }
            }

          
        }

        
        private void thucuong_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable data = new DataTable();
            data = DAL.QuanLiDoAn.getSanPhamTheoLoai(thucuong.Text);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    FoodItem item = new FoodItem(cart,totalprice, totalquantity);
                    item.ID = Convert.ToInt32(row["IDSP"]);
                    item.Name = row["TENSP"].ToString();
                    item.Price = Convert.ToInt32(row["GIATIEN"]);
                    item.Quantity = Convert.ToInt32(row["SOLUONG"]);
                    item.Img = Image.FromFile(row["PICTURE"].ToString());
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        private void thucan_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable data = new DataTable();
            data = DAL.QuanLiDoAn.getSanPhamTheoLoai(thucan.Text);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    FoodItem item = new FoodItem(cart, totalprice, totalquantity);
                    item.ID = Convert.ToInt32(row["IDSP"]);
                    item.Name = row["TENSP"].ToString();
                    item.Price = Convert.ToInt32(row["GIATIEN"]);
                    item.Quantity = Convert.ToInt32(row["SOLUONG"]);
                    item.Img = Image.FromFile(row["PICTURE"].ToString());
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        private void tatca_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadData();
        }
        private void LoadCart()
        {
            DataTable data = new DataTable();
            string query = "select * from cart c join sanpham sp on c.idsp = sp.idsp";
            data = DAL.DataProvider.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    CartItem item = new CartItem(totalprice, totalquantity);
                    item.ID = Convert.ToInt32(row["ID"]);
                    item.Name = row["TENSP"].ToString();
                    item.Type = row["LOAISP"].ToString();
                    item.Price = Convert.ToInt32(row["GIATIEN"]);
                    item.Img = Image.FromFile(row["PICTURE"].ToString());
                    cart.Controls.Add(item);
                }
            }
        }

        private void thanhtoanbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string today = DateTime.Today.Date.ToString("dd/MM/yyyy");
                TimKhachHang newForm = new TimKhachHang(IDNV, "DOAN");
                newForm.ShowDialog();
                
                
                MessageBox.Show("Thanh toán thành công !!!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
