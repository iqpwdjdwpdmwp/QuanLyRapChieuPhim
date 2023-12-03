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
    }
}
