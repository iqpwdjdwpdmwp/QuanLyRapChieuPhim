using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace DAL
{
    public class QuanLiNhanVien
    {
        public static DataTable getAllStaff()
        {
            string query = "select * from nhanvien";
            return DataProvider.ExecuteQuery(query);
        }
        public bool insertStaff(string staffname, string staffsex, string staffgmail, string staffphone, string staffbirth, string staffjob, string daystart)
        {
            string query = $"Insert into nhanvien (hoten, gioitinh, email, sdt, ngaysinh, chucvu, ngaybd) values (N'{staffname}','{staffsex}',N'{staffgmail}',N'{staffphone}',N'{staffbirth}','{staffjob}',N'{daystart}')";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public static DataTable getStaffDetail(int IDNV)
        {
            string query = $"select * from NHANVIEN where IDNV = {IDNV}";
            return DataProvider.ExecuteQuery(query);
        }
        public static bool updateNhanVien(int IDNV, string staffname, string staffsex, string staffgmail, string staffphone, string staffbirth, string staffjob, string daystart)
        {
            string query = "update NHANVIEN " +
                $"set HOTEN = N'{staffname}', EMAIL = N'{staffgmail}', GIOITINH = '{staffsex}', SDT = N'{staffphone}', NGAYSINH = '{staffbirth}', CHUCVU = N'{staffjob}', NGAYBD = N'{daystart}'"
                + $" where IDNV = {IDNV}";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
        public static bool deleteNhanVien(int IDNV)
        {
            string query = $"delete from NHANVIEN where IDNV ={IDNV}";
            int result = DataProvider.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
