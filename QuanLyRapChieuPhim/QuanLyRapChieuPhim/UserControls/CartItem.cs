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
    public partial class CartItem : UserControl
    {
        Label totalPrice;
        Label totalQuantity;
        public int ID { get; set; }
        private string name;
        private string type;
        private int price;
        private Image img;
        private int quantity = 1;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                namelb.Text = value;
            }
        }
        public string Type
        {
            get => this.type;
            set
            {
                this.type = value;
                typelb.Text = value;
            }
        }
        public int Price
        {
            get => this.price;
            set
            {
                this.price = value;
                pricelb.Text = value.ToString();
            }
        }
        public Image Img
        {
            get => this.img;
            set
            {
                this.img = value;
                guna2CirclePictureBox1.Image = value;
            }
        }
        public CartItem(Label totalPrice, Label totalQuantity)
        {
            InitializeComponent();
            quantitylb.Text = quantity.ToString();
            this.totalPrice = totalPrice;
            this.totalQuantity = totalQuantity;
            
        }
        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ++this.quantity;
            string query = $"UPDATE CART SET SOLUONG = {this.quantity} WHERE ID = {ID}";
            DAL.DataProvider.ExecuteNonQuery(query);
            quantitylb.Text = quantity.ToString();
            totalPrice.Text = getTotalPrice().ToString();
            totalQuantity.Text = getTotalQuantity().ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            --this.quantity;
            string query = $"UPDATE CART SET SOLUONG = {this.quantity} WHERE ID = {ID}";
            DAL.DataProvider.ExecuteNonQuery(query);
            quantitylb.Text = quantity.ToString();
            totalPrice.Text = getTotalPrice().ToString();
            totalQuantity.Text = getTotalQuantity().ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {

        }
        private int getTotalQuantity()
        {
            string query = "select sum(c.soluong) from cart c join sanpham sp on c.idsp = sp.idsp";
            int totalPrice = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            return totalPrice;
        }
        private int getTotalPrice()
        {
            string query = "select sum(sp.giatien * c.soluong) from cart c join sanpham sp on c.idsp = sp.idsp";
            int totalQuantity = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            return totalQuantity;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            string query = $"select SOLUONG from CART where ID = {ID}";
            int soLuong = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            this.quantity = soLuong;
            quantitylb.Text = soLuong.ToString();
        }
    }
}
