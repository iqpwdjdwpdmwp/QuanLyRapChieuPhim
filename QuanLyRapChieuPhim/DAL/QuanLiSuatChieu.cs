using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class QuanLiSuatChieu
    {
        public static DataTable getAllSuatChieu()
        {
            string query = "select * from suatchieu";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static DataTable getSuatChieu(int idphong)
        {
            string query = $"select * from suatchieu where IDPHONG = {idphong}";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static bool insertSuatChieu(int movieid, string ngaychieu, int phongid, string giochieu)
        {

            string query = $"insert into suatchieu (IDPHIM,IDPHONG,NGAYCHIEU,THOIGIANCHIEU) values ({movieid},{phongid},'{ngaychieu}','{giochieu}')";
            int data = DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static bool updateSuatChieu(int movieid, string giochieu)
        {
            string query = $"update suatchieu set giochieu = '{giochieu}' where movieid = {movieid}";
            int data = DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static bool deleteSuatChieu(int IDSUATCHIEU)
        {
            string query = $"delete from SUATCHIEU where IDSUATCHIEU = {IDSUATCHIEU}";
            int data = DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static DataTable getSuatChieuTheoID(int IDPHIM)
        {
            string today = DateTime.Now.Date.ToString();
            string query = $"select * from SUATCHIEU where IDPHIM = {IDPHIM} and  NGAYCHIEU = '{today}' order by THOIGIANCHIEU ASC";
            return DataProvider.ExecuteQuery(query);
        }
        
    }
}
