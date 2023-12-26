using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class KhachHang
    {
        public static bool insertKhachHang(string hoTen, string gioiTinh, string diaChi, string email, string sdt, string ngaySinh, string ngayDK)
        {
            string query = $"INSERT INTO KHACHHANG(HOTEN,GIOITINH,DIACHI,EMAIL,SDT,NGAYSINH,NGAYDK) VALUES (N'{hoTen}', N'{gioiTinh}', N'{diaChi}', '{email}', '{sdt}', '{ngaySinh}', '{ngayDK}')";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
        public static DataTable findKhachHang(string email)
        {
            string query = $"SELECT * FROM KHACHHANG WHERE EMAIL = '{email}'";
            return DAL.DataProvider.ExecuteQuery(query);
        }
    }
}
