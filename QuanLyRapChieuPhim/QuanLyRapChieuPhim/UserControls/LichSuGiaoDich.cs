using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class LichSuGiaoDich : UserControl
    {
        public LichSuGiaoDich()
        {
            InitializeComponent();
        }

        private void LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = DAL.LichSuGiaoDich.getLogs();
            if(data.Rows.Count > 0 ) { 
                foreach(DataRow row in data.Rows)
                {
                    logs.Rows.Add(new object[]
                    {
                        row["IDHD"].ToString(),
                        row["TENSP"].ToString(),
                        "NV" + row["IDNV"].ToString(),
                        "KH" + row["IDKH"].ToString(),
                        row["SOLUONG"].ToString(),
                        row["TONG"].ToString(),
                        row["NGHD"].ToString(),
                        row["GIOHD"].ToString()

                    });
                }
            }
        }
    }
}
