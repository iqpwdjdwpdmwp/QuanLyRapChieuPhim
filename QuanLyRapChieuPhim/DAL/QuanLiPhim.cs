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
            string query = "select * from movie";
            return DataProvider.ExecuteQuery(query);
        }
        public bool insertMovie(string moviename, string movietype, string moviegenre, string moviecountry, string path, string movieduration)
        {
            string query = $"Insert into movie (name,type,genre,country,moviepic,duration) values (N'{moviename}','{movietype}',N'{moviegenre}',N'{moviecountry}',N'{path}',{movieduration})";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
