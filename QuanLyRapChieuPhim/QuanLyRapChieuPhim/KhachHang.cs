using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class KhachHang : Form
    {
        public int IDNV { get; set; }
        public KhachHang(int IDNV)
        {
            InitializeComponent();
            this.IDNV = IDNV;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

            string sex = "";
            bool isChecked = male.Checked;
            if (isChecked)
            {
                sex = male.Text;
            } else sex = female.Text;
            //string hoTen, string gioiTinh, string diaChi, string email, string sdt, string ngaySinh, string ngayDK;
            try
            {
                
                DAL.KhachHang.insertKhachHang(namelb.Text, sex, addresslb.Text, emaillb.Text, phonelb.Text, dateborn.Value.Date.ToString("dd/MM/yyyy"), dateregister.Value.Date.ToString("dd/MM/yyyy"));
               
                
                MessageBox.Show("Thêm khách hàng thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
