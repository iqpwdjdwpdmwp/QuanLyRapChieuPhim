﻿using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL
{
    public class Account
    {
        public bool insertAccount(string tdn, string matkhau, int pq)
        {
            string query = $"insert into TAIKHOAN (TENDN, MKHAU, PHANQUYEN) values (N'{tdn}',N'{matkhau}', {pq})";
            int data = DAL.DataProvider.ExecuteNonQuery(query);
            return data > 0;
        }
        public static bool updateAccount(int IDACCOUNT, int pq)
        {
            string query = "update TAIKHOAN " +
                $"set PHANQUYEN = N'{pq}'"
                + $" where IDACCOUNT = {IDACCOUNT}";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
