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
        public static bool insertCTHDVE(int IDHD, string tenSP, int IDVE, int soLuongVe, int tongTien)
        {
            string query = $"INSERT INTO CTHDVE(IDHD, TENSP, IDVE, SOLUONGVE,TONGTIEN) VALUES({IDHD},N'{tenSP}',{IDVE}, {soLuongVe}, {tongTien})";
            return DAL.DataProvider.ExecuteNonQuery(query) > 0;
        }
        public static DataTable getLogs()
        {
            string query = "SELECT HD.IDHD, V.TENSP, sum(TONGTIEN) as 'tong', HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, count(*) as 'soluong' FROM HOADON HD join CTHDVE V on HD.IDHD = V.IDHD group by HD.IDHD, HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, V.TENSP\r\nunion\r\nSELECT HD.IDHD, SP.TENSP, sum(TONGTIEN) as 'tong', HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, count(*) as 'soluong' FROM HOADON HD JOIN CTHDSP CT on HD.IDHD = CT.IDHD join SANPHAM SP on SP.IDSP = CT.IDSP  group by HD.IDHD, HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD,SP.TENSP";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static DataTable getLogsTheoTimKiem(string from, string to, string product, string maNV, string maKH)
        {
            string query = String.Empty;
            query = $"SELECT HD.IDHD, TENSP, sum(TONGTIEN) as 'tong', HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, count(*) as 'soluong' FROM HOADON HD join CTHDVE V on HD.IDHD = V.IDHD WHERE NGHD >= '{from}' AND NGHD <= '{to}' {(product == "" ? "" : $"AND V.TENSP LIKE N'%{product}%'")} {(maNV == "" ? "" : $"AND IDNV = {Convert.ToInt32(maNV)}")} {(maKH == "" ? "" : $"AND IDKH = {Convert.ToInt32(maKH)}")} group by HD.IDHD, HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, V.TENSP\r\nunion\r\n" +
                $"SELECT HD.IDHD, SP.TENSP, sum(TONGTIEN) as 'tong', HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD, count(*) as 'soluong' FROM HOADON HD JOIN CTHDSP CT on HD.IDHD = CT.IDHD join SANPHAM SP on SP.IDSP = CT.IDSP  WHERE NGHD >= '{from}' AND NGHD <= '{to}' {(product == "" ? "" : $"AND SP.TENSP LIKE N'%{product}%'")} {(maNV == "" ? "" : $"AND IDNV = {Convert.ToInt32(maNV)}")} {(maKH == "" ? "" : $"AND IDKH = {Convert.ToInt32(maKH)}")}  group by HD.IDHD, HD.NGHD, HD.IDNV, HD.IDKH, HD.GIOHD,SP.TENSP";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        
    }
}
