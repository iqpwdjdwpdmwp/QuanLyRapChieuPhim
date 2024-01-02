using System;
using System.Collections;
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
    public partial class Calendar_Day : UserControl
    {
        int day;
        int month;
        int year;
        public string NhanVien
        {
            set
            {
                nv.Text = value;
            }
        }
        public Calendar_Day(int day, int month, int year)
        {
            InitializeComponent();
            this.day = day;
            this.month = month;
            this.year = year;
            
        }

        private void Calendar_Day_Click(object sender, EventArgs e)
        {

            PhanCong newForm = new PhanCong(day, month, year);
            newForm.ShowDialog();
            LoadData();
        }

        private void Calendar_Day_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT * FROM PHANCONG";
            DataTable data = new DataTable();
            data = DAL.DataProvider.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    string ngay = (new DateTime(year, month,day)).ToString("MM/dd/yyyy");
                    if (Convert.ToDateTime(row["NGAYLAMVIEC"]).ToString("MM/dd/yyyy") == ngay)
                    {
                        query = $"SELECT HOTEN FROM NHANVIEN WHERE IDNV = {Convert.ToInt32(row["IDNV"])}";
                        nv.Text = DAL.DataProvider.ExecuteScalar(query).ToString();
                    }
                }
            }
            label1.Text = day.ToString();
        }
    }
}
