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
            string query = $"select * from suatchieu where phongid = {idphong}";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static bool insertSuatChieu(int movieid, DateTime ngaychieu, int phongid, string giochieu, string description)
        {

            string query = $"insert into suatchieu (movieid,ngaychieu,phongid,giochieu,description) values ({movieid},'{ngaychieu}',{phongid},'{giochieu}',N'{description}') ";
            int data = DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static bool updateSuatChieu(int movieid, string giochieu)
        {
            string query = $"update suatchieu set giochieu = '{giochieu}' where movieid = {movieid}";
            int data = DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
    }
}
