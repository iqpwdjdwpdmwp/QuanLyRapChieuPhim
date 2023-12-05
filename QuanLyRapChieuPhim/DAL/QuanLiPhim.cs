using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace DAL
{
    public class QuanLiPhim
    {
        public static DataTable getAllMovie()
        {
            string query = "select * from phim";
            return DataProvider.ExecuteQuery(query);
        }
        public bool insertMovie(string moviename, string movietype, string moviegenre, string moviecountry, string path, string movieduration, string moviedescription, string tacgia, string namphathanh)
        {
            string query = $"Insert into phim (tenphim,dangphim,theloai,quocgia,poster,thoiluong,mota,tacgia, namphathanh) values (N'{moviename}','{movietype}',N'{moviegenre}',N'{moviecountry}',N'{path}','{movieduration}',N'{moviedescription}', N'{tacgia}', '{namphathanh}')";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public static DataTable getMovieDetail(int IDPHIM)
        {
            string query = $"select * from PHIM where IDPHIM = {IDPHIM}";
            return DataProvider.ExecuteQuery(query);
        }
        public static bool updateMovie(int IDPHIM,string moviename, string movietype, string moviegenre, string moviecountry, string path, string movieduration, string moviedescription, string tacgia, string namphathanh)
        {
            string query = "update PHIM " +
                $"set TENPHIM = N'{moviename}', THELOAI = N'{moviegenre}', DANGPHIM = '{movietype}', QUOCGIA = N'{moviecountry}', THOILUONG = '{movieduration}', MOTA = N'{moviedescription}', TACGIA = N'{tacgia}', NAMPHATHANH = '{namphathanh}', POSTER = N'{path}'"
                + $" where IDPHIM = {IDPHIM}";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public static bool deleteMovie(int IDPHIM)
        {
            string query = $"delete from PHIM where IDPHIM ={IDPHIM}";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
