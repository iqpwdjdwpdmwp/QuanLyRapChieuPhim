using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class TimKhachHang : Form
    {
        public int IDNV { get; set; }
        public int IDKH { get; set; }
        public string Tab { get; set; }
        public TimKhachHang(int IDNV, string tab)
        {
            InitializeComponent();
            this.IDNV = IDNV;
            this.Tab = tab;
        }

        private void emailfinding_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataTable data = new DataTable();
                data = DAL.KhachHang.findKhachHang(emailfinding.Text);
                if(data.Rows.Count < 1)
                {
                    MessageBox.Show("Email hiện tại chưa được khởi tạo, vui lòng thử lại");
                } else
                {
                    namelb.Text = data.Rows[0]["HOTEN"].ToString();
                    emaillb.Text = data.Rows[0]["EMAIL"].ToString();
                    addresslb.Text = data.Rows[0]["DIACHI"].ToString();
                    phonelb.Text = data.Rows[0]["SDT"].ToString();
                    this.IDKH = Convert.ToInt32(data.Rows[0]["IDKH"]);
                    
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KhachHang newForm = new KhachHang(IDNV);
            newForm.ShowDialog();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToString("");
            DataTable data = new DataTable();

            
            MailMessage mm = new MailMessage();
            SmtpClient sc = new SmtpClient("smtp.gmail.com");
            mm.From = new MailAddress("22520487@gm.uit.edu.vn");
            mm.To.Add(new MailAddress(emaillb.Text));
            DAL.LichSuGiaoDich.insertHD(DateTime.Today.ToString("dd/MM/yyyy"), IDKH, this.IDNV);
            if(Tab == "DATVE")
            {
                string query = $"SELECT P.TENPHIM, SC.IDPHONG, SC.NGAYCHIEU, SOLUONGVE, TONGTIEN, NV.HOTEN, G.MAGHE   FROM HOADON HD JOIN CTHDVE CT on HD.IDHD = CT.IDHD join VE V \r\non CT.IDVE = V.IDVE join SUATCHIEU SC on V.IDSUATCHIEU = SC.IDSUATCHIEU join PHIM P \r\non SC.IDPHIM = P.IDPHIM join GHE G on V.IDGHE = G.IDGHE join NHANVIEN NV on HD.IDNV = NV.IDNV WHERE IDKH = {IDKH} and NGAYCHIEU = '{today}'";
                data = DAL.DataProvider.ExecuteQuery(query);
                string name = String.Empty;
                string phong = String.Empty;
                string maGhe = String.Empty;
                int totalQuantity = 0;
                int totalPrice = 0;
                string nameEmp = String.Empty;
                string date = String.Empty;
                string gioChieu = String.Empty;
                if (data.Rows.Count > 0)
                {
                    name = data.Rows[0]["TENPHIM"].ToString();
                    phong = "P" + data.Rows[0]["IDPHONG"].ToString();
                    maGhe = String.Empty;
                    nameEmp = data.Rows[0]["HOTEN"].ToString();
                    date = (Convert.ToDateTime(data.Rows[0]["NGAYCHIEU"])).ToString("dd/MM/yyyy");
                    gioChieu = data.Rows[0]["THOIGIANCHIEU"].ToString();
                    totalQuantity = 0;
                    totalPrice = 0;
                    int i = 0;
                    foreach (DataRow row in data.Rows)
                    {

                        totalQuantity += Convert.ToInt32(row["SOLUONGVE"]);
                        totalPrice += Convert.ToInt32(row["TONGTIEN"]);

                        if (i == data.Rows.Count - 1)
                        {
                            maGhe += row["MAGHE"].ToString();
                        }
                        else
                        {
                            maGhe += row["MAGHE"].ToString() + ", ";
                        }
                        ++i;
                    }
                }

                mm.Subject = "HÓA ĐƠN MUA VÉ";
                mm.Body = "Cinema xin kính chào quý khách," + "\n" + $"Tên phim:  {name}" + "\n" + $"Phòng chiếu: {phong}" + $"Số ghế: {maGhe}" + "\n" + $"Số lượng: {totalQuantity}" + "\n" + $"Tổng tiền: {totalPrice}" + "\n" + $"Nhân viên bán vé: {nameEmp}" + "\n" + $"Ngày: {date}" + "\n" + $"Giờ chiếu: {gioChieu}";
            } else
            {
                string query = "SELECT MAX(IDHD) FROM HOADON";

                int IDHD = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
                query = "SELECT * FROM CART";
                data = DAL.DataProvider.ExecuteQuery(query);
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        query = $"INSERT INTO CTHDSP(IDHD,IDSP,SOLUONGSP,TONGTIEN) VALUES ({IDHD},{Convert.ToInt32(row["IDSP"])}, {Convert.ToInt32(row["SOLUONG"])}, {Convert.ToInt32(row["TONGTIEN"])})";
                        DAL.DataProvider.ExecuteNonQuery(query);
                    }
                }
                query = $"SELECT TENSP, LOAISP, CT.SOLUONGSP, CT.TONGTIEN, HOTEN, NGHD, GIOHD FROM HOADON HD JOIN CTHDSP CT ON HD.IDHD = CT.IDHD JOIN NHANVIEN NV ON HD.IDNV = NV.IDNV JOIN SANPHAM SP ON CT.IDSP = SP.IDSP WHERE NGHD = '{DateTime.Today.ToString("dd/MM/yyyy")}' and IDKH = {IDKH}";
                data = DAL.DataProvider.ExecuteQuery(query);
                string name = String.Empty;
                string type = String.Empty;
                int soLuong = 0;
                int tongTien = 0;
                string nameEmp = String.Empty;
                string ngHD = String.Empty;
                string gioHD = String.Empty;
                int i = 0;
                if(data.Rows.Count > 0)
                {
                    foreach(DataRow row in data.Rows)
                    {
                        if(i == data.Rows.Count - 1)
                        {
                            name += row["TENSP"].ToString();
                        } else
                        {
                            name += row["TENSP"].ToString() + ", ";
                        }
                        type = row["LOAISP"].ToString();
                        soLuong += Convert.ToInt32(row["SOLUONGSP"]);
                        tongTien += Convert.ToInt32(row["TONGTIEN"]);
                        nameEmp = row["HOTEN"].ToString();
                        ngHD = row["NGHD"].ToString();
                        gioHD = row["GIOHD"].ToString();
                        ++i;
                    }
                }

                mm.Subject = "HÓA ĐƠN MUA THỨC ĂN";
              
                mm.Body = "Cinema xin kính chào quý khách," + "\n" + $"Tên sản phẩm: {name}" + "\n" + $"Loại sản phẩm: {type}" + "\n" + $"Số lượng: {soLuong}" + "\n" + $"Tổng tiền: {tongTien}" + "\n" + $"Ngày: {ngHD}" + "\n" + $"Giờ: {gioHD}" + "\n" + $"Nhân viên bán hàng: {nameEmp}";   ;
            }
            sc.Port = 587;
            sc.Credentials = new System.Net.NetworkCredential("22520487@gm.uit.edu.vn", "1653789911");
            sc.EnableSsl = true;
            sc.Send(mm);
            MessageBox.Show("Gửi hóa đơn thành công");
        }
    }
}
