using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim.UserControls
{
    public partial class LichLamViec : UserControl
    {
        int year, month;
        public LichLamViec()
        {
            InitializeComponent();
        }

        private void LichLamViec_Load(object sender, EventArgs e)
        {

            LoadData();

        }
        private void LoadData()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthandyearlb.Text = monthName + " " + year.ToString();
            DateTime firstDateOfTheMonth = new DateTime(year, month, 1);


            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(firstDateOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                Calendar_Blank CB = new Calendar_Blank();
                flowLayoutPanel1.Controls.Add(CB);
            }
            
            for (int i = 1; i <= days; i++)
            {
                Calendar_Day UD = new Calendar_Day(i, month, year);
                
                flowLayoutPanel1.Controls.Add(UD);
            }
        }
        private void nextmonth_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DateTime now = DateTime.Now;
            
            ++month;
            if(month == 13)
            {
                month = 1;
                ++year;
            }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthandyearlb.Text = monthName + " " + year.ToString();
            DateTime firstDateOfTheMonth = new DateTime(year, month, 1);
            
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(firstDateOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                Calendar_Blank CB = new Calendar_Blank();
                flowLayoutPanel1.Controls.Add(CB);
            }
            for (int i = 1; i <= days; i++)
            {
                Calendar_Day UD = new Calendar_Day(i, month, year);
                flowLayoutPanel1.Controls.Add(UD);
            }
        }

        private void prevmonth_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DateTime now = DateTime.Now;
            
            --month;
            if(month == 0)
            {
                month = 12;
                --year;
            }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthandyearlb.Text = monthName + " " + year.ToString();
            DateTime firstDateOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int daysOfTheWeek = Convert.ToInt32(firstDateOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < daysOfTheWeek; i++)
            {
                Calendar_Blank CB = new Calendar_Blank();
                flowLayoutPanel1.Controls.Add(CB);
            }
            for (int i = 1; i <= days; i++)
            {
                Calendar_Day UD = new Calendar_Day(i, month, year);
                flowLayoutPanel1.Controls.Add(UD);
            }
        }
    }
}
