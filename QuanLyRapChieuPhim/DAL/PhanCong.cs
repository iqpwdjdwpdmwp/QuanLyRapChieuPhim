using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class PhanCong
    {
        public static bool themNgayLamViec(int IDNV, string NGAYLAMVIEC)
        {
            string query = $"INSERT INTO PHANCONG(IDNV,NGAYLAMVIEC) VALUES({IDNV}, '{NGAYLAMVIEC}')";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
    }
}
