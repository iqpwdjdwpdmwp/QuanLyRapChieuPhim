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
        public static DataTable getDoanhThuNhanVien()
        {
            string query = "with uniontables as (\r\nSELECT HD.IDNV, NV.HOTEN, SUM(TONGTIEN) AS 'TONG' FROM HOADON HD JOIN CTHDVE CTV ON HD.IDHD = CTV.IDHD JOIN NHANVIEN NV ON HD.IDNV = NV.IDNV GROUP BY HD.IDNV, NV.HOTEN\r\nUNION\r\nSELECT HD.IDNV, NV.HOTEN, SUM(TONGTIEN) AS 'TONG' FROM HOADON HD JOIN CTHDSP CT ON HD.IDHD = CT.IDHD JOIN NHANVIEN NV ON HD.IDNV = NV.IDNV GROUP BY HD.IDNV, NV.HOTEN\r\n) SELECT IDNV, HOTEN, SUM(TONG) as 'TONG' FROM uniontables group by IDNV, HOTEN ORDER BY TONG DESC";
            return DAL.DataProvider.ExecuteQuery(query);
        }
        public static DataTable getChiTieuKhachHang()
        {
            string query = "with uniontables as (\r\nSELECT HD.IDKH, KH.HOTEN, SUM(TONGTIEN) AS 'TONG' FROM HOADON HD JOIN CTHDVE CTV ON HD.IDHD = CTV.IDHD JOIN KHACHHANG KH ON HD.IDKH = KH.IDKH GROUP BY HD.IDKH, KH.HOTEN\r\nUNION\r\nSELECT HD.IDKH, KH.HOTEN, SUM(TONGTIEN) AS 'TONG' FROM HOADON HD JOIN CTHDSP CT ON HD.IDHD = CT.IDHD JOIN KHACHHANG KH ON HD.IDKH = KH.IDKH GROUP BY HD.IDKH, KH.HOTEN\r\n) SELECT IDKH, HOTEN, SUM(TONG) as 'TONG' FROM uniontables group by IDKH, HOTEN ORDER BY TONG DESC";
            return DAL.DataProvider.ExecuteQuery(query);

        }
    }
}
