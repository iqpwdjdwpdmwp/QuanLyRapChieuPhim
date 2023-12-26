using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Ve
    {
        public static bool insertVe(int IDNV, int IDPHIM, int IDSUATCHIEU, int IDGHE, int giaVe)
        {
            string query = $"INSERT INTO VE(IDNV,IDPHIM,IDSUATCHIEU,IDGHE,GIAVE) VALUES({IDNV}, {IDPHIM}, {IDSUATCHIEU}, {IDGHE}, {giaVe})";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
