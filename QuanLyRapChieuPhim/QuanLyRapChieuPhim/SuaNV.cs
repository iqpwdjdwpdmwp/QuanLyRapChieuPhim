using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class SuaNV : Form
    {
        private int idNV;
        //private string OldImg { get; set; }
        //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\staff_pictures\";

        public int IDNV
        {
            get { return idNV; }
            set { idNV = value; }
        }

        public SuaNV(int IDNV)
        {
            InitializeComponent();
            this.IDNV = IDNV;
        }

        public DateTime String_DateTime(string calendar)
        {
            string kq = calendar;
            // Tạo một chuỗi mới để lưu kết quả sau khi thay đổi
            string modifiedString = "";

            for (int i = 0; i < kq.Length; i++)
            {
                char character = kq[i];
                if (character != '/')
                {
                    // Thay thế dấu / bằng dấu ,
                    modifiedString += character;
                }
            }
            DateTime dateTimeValue;
            DateTime.TryParseExact(modifiedString, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeValue);
            return dateTimeValue;
        }


            private void SuaNV_Load(object sender, EventArgs e)
        {
            DataTable data = DAL.QuanLiNhanVien.getStaffDetail(IDNV);
            foreach (DataRow row in data.Rows)
            {

                staffname.Text = row["HOTEN"].ToString();
                staffsex.Text = row["GIOITINH"].ToString();
                staffgmail.Text = row["EMAIL"].ToString();
                staffphone.Text = row["SDT"].ToString();
                staffjob.Text = row["CHUCVU"].ToString();
                DateTime datetimevalue = String_DateTime(row["NGAYSINH"].ToString());
                staffbirth.Value = datetimevalue;
                datetimevalue= String_DateTime(row["NGAYBD"].ToString());
                daystart.Value = datetimevalue;
            }
        }
        private void submit_Click(object sender, EventArgs e)
        {

            //string path = Path.Combine(appPath, staffname.Text + ".jpg");
            //Image img = staffpicture.Image;
            //img.Save(path);
            //img.Dispose();
            //File.Delete(OldImg.ToString());

            try
            {
                string start = daystart.Value.Date.ToString("dd/MM/yyyy");
                string birth = staffbirth.Value.Date.ToString("dd/MM/yyyy");
                bool data = DAL.QuanLiNhanVien.updateNhanVien(IDNV, staffname.Text, staffsex.Text, staffgmail.Text, staffphone.Text, birth, staffjob.Text, start);
                MessageBox.Show("Cập nhật nhân viên thành công !!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
