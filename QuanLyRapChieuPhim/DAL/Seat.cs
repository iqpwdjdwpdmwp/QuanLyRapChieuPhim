using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class Seat
    {
        public static DataTable getAllSeats(int suatChieu_ID)
        {
            string query = $"select * from GHE where IDSUATCHIEU = {suatChieu_ID}";
            DataTable data = DAL.DataProvider.ExecuteQuery(query);
            return data;
        }
        public static bool insertSeat(string name, int suatChieu_ID, char firstLetter)
        {
            string type = Convert.ToInt32(firstLetter) > Convert.ToInt32('D') ? "VIP" : "Thường";
            string query = $"insert into GHE (MAGHE,IDSUATCHIEU,TRANGTHAI, LOAIGHE) values (N'{name}',{suatChieu_ID},1, N'{type}')";
            int data = DAL.DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static bool updateSeat(string nameSeat, int suatChieu_ID)
        {
            string query = $"update GHE set TRANGTHAI = 1 where MAGHE = '{nameSeat}' and IDSUATCHIEU = {suatChieu_ID}";
            int data = DAL.DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }

    }
}
