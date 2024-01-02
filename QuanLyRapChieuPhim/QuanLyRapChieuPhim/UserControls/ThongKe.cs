using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100000;

            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 20000;

            chart1.Series.Add("Doanh thu");
            chart1.Series["Doanh thu"].ChartType = SeriesChartType.Spline;
            chart1.Series["Doanh thu"].Color = Color.Brown;
            chart1.Series[0].IsVisibleInLegend = false;

            //DataTable data = new DataTable();
            //data = DAL.ThongKe.getDoanhThuNamCuaVe();
            //if(data.Rows.Count > 0)
            //{
            //    foreach(DataRow row in data.Rows)
            //    {
            //        MessageBox.Show(row["MONTH"].ToString());
            //        chart1.Series["Doanh thu"].Points.AddXY(Convert.ToInt32(row["MONTH"]), Convert.ToDouble(row["TONG"]));
            //    }
            //}
            Random rand = new Random();
            for(int i = 1; i <= 12; i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(i, rand.Next(20000, 100000));
            }

            chart = chart2.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 100000;

            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 20000;

            chart2.Series.Add("Doanh thu");
            chart2.Series["Doanh thu"].ChartType = SeriesChartType.Spline;
            chart2.Series["Doanh thu"].Color = Color.Brown;
            chart2.Series[0].IsVisibleInLegend = false;

            for (int i = 1; i <= 12; i++)
            {
                chart2.Series["Doanh thu"].Points.AddXY(i, rand.Next(20000, 100000));
            
            }

            DataTable data = new DataTable();
            data = DAL.ThongKe.getDoanhThuNhanVien();
            int count = 1;
            if(data.Rows.Count > 0)
            {
                foreach(DataRow row in data.Rows)
                {
                    doanhthunhanvien.Rows.Add(new object[]
                    {
                        count.ToString(),
                        "NV" + row["IDNV"].ToString(),
                        row["HOTEN"].ToString(),
                        row["TONG"].ToString()
                    });
                    ++count;
                }
            }

            data = DAL.ThongKe.getChiTieuKhachHang();
            count = 1;
            //if (data.Rows.Count > 0)
            //{
            //    foreach (DataRow row in data.Rows)
            //    {
            //        chitieukhachhang.Rows.Add(new object[]
            //        {
            //            count.ToString(),
            //            "NV" + row["IDKH"].ToString(),
            //            row["HOTEN"].ToString(),
            //            row["TONG"].ToString()
            //        });
            //        ++count;
            //    }
            //}
        }
    }
}
