using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class PhimDangChieu
    {
        public static DataTable getPhimDangChieu(string date)
        {
            string today = DateTime.Today.ToString();   
            string query = $"select distinct P.IDPHIM, THOILUONG, THELOAI, DANGPHIM, TENPHIM, THELOAI, POSTER, NGAYCHIEU, IDPHONG, MOTA, QUOCGIA from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{date}'";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static DataTable getPhimTheoPhanLoai(string theloai,string quocgia, int thoiluong, string date)
        {
            string today = DateTime.Today.ToString();
            string query = String.Empty;
            if(theloai == "Tất cả")
            {
                query = $"select distinct P.IDPHIM, THOILUONG, THELOAI, DANGPHIM, TENPHIM, THELOAI, POSTER, NGAYCHIEU, IDPHONG, MOTA from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{date}' {(quocgia == "Tất cả" ? "" : $"and QUOCGIA = N'{quocgia}'")} {(thoiluong == 0 ? "" : $"and THOILUONG < {thoiluong}")}";
            } else
            {
                query = $"select distinct P.IDPHIM, THOILUONG, THELOAI, DANGPHIM, TENPHIM, THELOAI, POSTER, NGAYCHIEU, IDPHONG, MOTA  from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{date}' and P.THELOAI LIKE N'%{theloai}%' {(quocgia == "Tất cả" ? " " : $"and QUOCGIA = N'{quocgia}'")} {(thoiluong == 0 ? "" : $"and THOILUONG < {thoiluong}")}";
            }
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static DataTable getIDPhimDangChieu()
        {
            string today = DateTime.Today.ToString();
            string query = $"select SC.IDSUATCHIEU from SUATCHIEU SC inner join PHIM P on SC.IDPHIM = P.IDPHIM where NGAYCHIEU = '{today}'";
            return DAL.DataProvider.ExecuteQuery(query);
        }
    }
}
