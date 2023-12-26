using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class PhimDangChieu
    {
        public static DataTable getPhimDangChieu()
        {
            string today = DateTime.Today.ToString();
            string query = $"select distinct P.IDPHIM, THOILUONG, THELOAI, DANGPHIM, TENPHIM, THELOAI, POSTER, NGAYCHIEU, IDPHONG, MOTA, SC.IDSUATCHIEU from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{today}'";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static DataTable getPhimTheoTheLoai(string theloai)
        {
            string today = DateTime.Today.ToString();
            string query = String.Empty;
            if(theloai == "Tất cả")
            {
                query = $"select distinct P.IDPHIM, THOILUONG, THELOAI, DANGPHIM, TENPHIM, THELOAI, POSTER, NGAYCHIEU, IDPHONG, MOTA, SC.IDSUATCHIEU from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{today}'";
            } else
            {
                query = $"select distinct P.IDPHIM, THOILUONG, THELOAI, DANGPHIM, TENPHIM, THELOAI, POSTER, NGAYCHIEU, IDPHONG, MOTA, SC.IDSUATCHIEU  from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{today}' and P.THELOAI LIKE N'%{theloai}%'";
            }
            return DAL.DataProvider.ExecuteQuery(query);
        }
    }
}
