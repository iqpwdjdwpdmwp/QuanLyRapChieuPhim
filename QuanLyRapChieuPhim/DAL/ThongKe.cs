using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class ThongKe
    {
        public static DataTable getDoanhThuNamCuaVe()
        {
            string query = "SELECT MONTH(CONVERT(DATE, NGHD)) as 'MONTH', SUM(TONGTIEN) AS 'TONG' FROM HOADON HD JOIN CTHDVE CTV ON HD.IDHD = CTV.IDHD GROUP BY NGHD ORDER BY MONTH(NGHD) ASC";
            return DAL.DataProvider.ExecuteQuery(query);
        }
    }
}
