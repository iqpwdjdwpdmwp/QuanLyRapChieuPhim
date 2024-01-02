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
            from.Value = DateTime.Today;
            to.Value = DateTime.Today;
        }

        private void LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = DAL.LichSuGiaoDich.getLogs();
            LoadData(data);
        }
        private void LoadData(DataTable data)
        {
            logs.Rows.Clear();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
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
        

        

        private void find_Click(object sender, EventArgs e)
        {
            string fromDate = from.Value.ToString("MM/dd/yyyy");
            string toDate = to.Value.ToString("MM/dd/yyyy");
            
            DataTable data = new DataTable();

            data = DAL.LichSuGiaoDich.getLogsTheoTimKiem(fromDate, toDate, productfinding.Text, empfinding.Text, guestfinding.Text);

            LoadData(data);
        }

        private void export_Click(object sender, EventArgs e)
        {

        }
    }
}
