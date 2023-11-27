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
            string query = $"select * from seat where suatchieu_id = {suatChieu_ID}";
            DataTable data = DAL.DataProvider.ExecuteQuery(query);
            return data;
        }
        public static bool insertSeat(string name, int suatChieu_ID)
        {
            string query = $"insert into seat (name,suatchieu_id,controng) values (N'{name}',{suatChieu_ID},0)";
            int data = DAL.DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static bool updateSeat(string nameSeat, int suatChieu_ID)
        {
            string query = $"update seat set controng = 1 where name = '{nameSeat}' and suatchieu_id = {suatChieu_ID}";
            int data = DAL.DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }

    }
}
