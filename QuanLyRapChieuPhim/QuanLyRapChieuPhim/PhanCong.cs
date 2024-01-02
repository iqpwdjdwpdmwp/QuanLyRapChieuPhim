using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class PhanCong : Form
    {
        int day, month, year;
        public PhanCong(int day, int month, int year)
        {
            InitializeComponent();
            this.day = day;
            this.month = month;
            this.year = year;
        }

        private void PhanCong_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN";
            DataTable data = new DataTable();
            data = DAL.DataProvider.ExecuteQuery(query);
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    dsnhanvien.Items.Add(row["HOTEN"].ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = $"SELECT IDNV FROM NHANVIEN WHERE HOTEN = N'{dsnhanvien.SelectedItem}'";
            int IDNV = Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            
            string ngayLamViec = (new DateTime(year, month, day)).ToString("MM/dd/yyyy");
            
            
            try
            {
                DAL.PhanCong.themNgayLamViec(IDNV, ngayLamViec);
                MessageBox.Show("Thêm ngày làm việc thành công");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
