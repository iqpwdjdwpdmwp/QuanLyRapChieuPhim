using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class LichSuGiaoDich
    {
        public static bool insertHD(string ngayHD, int IDKH, int IDNV)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string query = $"INSERT INTO HOADON(NGHD,IDKH,IDNV,GIOHD) VALUES ('{ngayHD}', {IDKH}, {IDNV}, '{time}')";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
        public static bool insertCTHDSP(int IDSP, int soLuong, int tongTien)
        {
            string query = $"INSERT INTO CTHDSP(IDSP,SOLUONGSP,TONGTIEN) VALUES({IDSP}, {soLuong}, {tongTien})";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
        public static bool insertCTHDVE(int IDHD, int IDVE, int soLuongVe, int tongTien)
        {
            string query = $"INSERT INTO CTHDVE(IDHD, IDVE, SOLUONGVE,TONGTIEN) VALUES({IDHD},{IDVE}, {soLuongVe}, {tongTien})";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
        public static DataTable getLogs()
        {
            string query = "SELECT HD.IDHD, 'Vé xem phim' as 'TENSP', sum(TONGTIEN) as 'tong', HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, count(*) as 'soluong' FROM HOADON HD join CTHDVE V on HD.IDHD = V.IDHD group by HD.IDHD, HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD\r\nunion\r\nSELECT HD.IDHD, SP.TENSP, sum(TONGTIEN) as 'tong', HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, count(*) as 'soluong' FROM HOADON HD JOIN CTHDSP CT on HD.IDHD = CT.IDHD join SANPHAM SP on SP.IDSP = CT.IDSP  group by HD.IDHD, HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD,SP.TENSP";
            return DAL.DataProvider.ExecuteQuery(query);
        }
    }
}
