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

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class FoodItem : UserControl
    {
        FlowLayoutPanel cart;
        Label totalPrice;
        Label totalQuantity;
        int id;
        string name1;
        int price1;
        int quantity1;
        Image img;
        public string Name {
            get
            {
                return name1;
            }
            set
            {
                this.name1 = value;
                name.Text = value;
            }
        }
        public int Price
        {
            get
            {
                return price1;
            }
            set
            {
                price1 = value;
                price.Text = value.ToString();
            }
        }
        public int Quantity
        {
            get
            {
                return quantity1;
            }
            set
            {
                quantity1 = value;
                quantity.Text = value.ToString();
            }
        }
        public int ID
        {
            get {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
        public Image Img
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
                guna2PictureBox1.Image = value;
            }
        }
        public FoodItem(FlowLayoutPanel cart, Label totalPrice, Label totalQuantity)
        {
            InitializeComponent();
            this.cart = cart;
            this.totalPrice = totalPrice;
            this.totalQuantity = totalQuantity;
        }

        private void addcartbtn_Click(object sender, EventArgs e)
        {
            string query = $"select * from CART where IDSP = {ID}";
            DataTable data = new DataTable();
            data = DAL.DataProvider.ExecuteQuery(query);
            if(data.Rows.Count > 0)
            {
                int ID = Convert.ToInt32(data.Rows[0]["ID"]);
                int soLuong = Convert.ToInt32(data.Rows[0]["SOLUONG"]);
                query = $"update CART set SOLUONG = {++soLuong}, TONGTIEN = TONGTIEN * (SOLUONG + 1) where ID = {ID}";
                try
                {
                    DAL.DataProvider.ExecuteNonQuery(query);
                    MessageBox.Show("Thêm vào giỏ hàng thành công");
                    totalPrice.Text = getTotalPrice().ToString();
                    totalQuantity.Text = getTotalQuantity().ToString();
                    LoadCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            } else
            {
                query = $"INSERT INTO CART VALUES ({ID},1, {Convert.ToInt32(price.Text)})";

                try
                {
                    DAL.DataProvider.ExecuteNonQuery(query);
                    MessageBox.Show("Thêm vào giỏ hàng thành công");
                    totalPrice.Text = getTotalPrice().ToString();
                    totalQuantity.Text = getTotalQuantity().ToString();
                    LoadCart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
        }
        private void LoadCart()
        {
            cart.Controls.Clear();
            DataTable data = new DataTable();
            string query = "select * from cart c join sanpham sp on c.idsp = sp.idsp";
            data = DAL.DataProvider.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    CartItem item = new CartItem(totalPrice, totalQuantity);
                    item.ID = Convert.ToInt32(row["ID"]);
                    item.Name = row["TENSP"].ToString();
                    item.Type = row["LOAISP"].ToString();
                    item.Price = Convert.ToInt32(row["GIATIEN"]);
                    item.Img = Image.FromFile(row["PICTURE"].ToString());
                    cart.Controls.Add(item);
                }
            }
        }
        private int getTotalQuantity()
        {
            string query = "select sum(sp.giatien * c.soluong) from cart c join sanpham sp on c.idsp = sp.idsp";
            int totalPrice = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            return totalPrice;
        }
        private int getTotalPrice()
        {
            string query = "select sum(c.soluong) from cart c join sanpham sp on c.idsp = sp.idsp";
            int totalQuantity = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            return totalQuantity;
        }
    }
}
