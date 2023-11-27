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
            string query = "select * from suatchieu sc inner join movie m on sc.movieid = m.id";
            return DAL.DataProvider.ExecuteQuery(query);
        }
    }
}
