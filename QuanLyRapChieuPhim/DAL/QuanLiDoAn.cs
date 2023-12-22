using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class QuanLiDoAn
    {
        public static DataTable getSanPham()
        {
            string query = "SELECT * FROM SANPHAM";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static bool insertSanPham(string name, int quantity, int price, string type, string path)
        {
            string query = $"INSERT INTO SANPHAM(TENSP, LOAISP, GIATIEN, SOLUONG, PICTURE) VALUES(N'{name}', N'{type}', {price}, {quantity}, N'{path}')";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        } 
        public static DataTable getSanPhamTheoLoai(string type)
        {
            string query = $"SELECT * FROM SANPHAM WHERE LOAISP = N'{type}'";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static bool clearCart()
        {
            string query = "delete from CART";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
