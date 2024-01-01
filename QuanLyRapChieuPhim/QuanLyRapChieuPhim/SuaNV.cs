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
using System.Text.RegularExpressions;
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
        public int pq,idacc;

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
                /*string datetimevalue = row["NGAYSINH"].ToString();
                staffbirth.Text = datetimevalue;
                datetimevalue = row["NGAYBD"].ToString();
                daystart.Text = datetimevalue;*/
                DateTime datetimevalue = String_DateTime(row["NGAYSINH"].ToString());
                staffbirth.Value = datetimevalue;
                datetimevalue = String_DateTime(row["NGAYBD"].ToString());
                daystart.Value = datetimevalue;
            }
            string query = $"SELECT (IDACCOUNT) FROM TAIKHOAN WHERE IDNV={IDNV}";
            idacc=Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            query = $"SELECT PHANQUYEN AS PQ FROM TAIKHOAN WHERE IDACCOUNT={idacc}";
            pq= Convert.ToInt32(DAL.DataProvider.ExecuteScalar(query));
            if (pq == 0 )
                checkAdmin.Checked = true;
            else checkAdmin.Checked = false;
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            EditNV();
        }

        private void EditNV()
        {
            //xu ly ngoai le
            //lay ngay bd, ngay sinh
            DateTime ngsinh = staffbirth.Value;
            DateTime ngBatDau = daystart.Value;
            if (staffname.Text == "" || staffsex.Text == "" || staffgmail.Text == "" || staffphone.Text == "" || staffjob.Text == "" || staffname.Text == "" || staffbirth.Value.Date.ToString("dd/MM/yyyy") == "" || daystart.Value.Date.ToString("dd/MM/yyyy") == "")
            {
                MessageBox.Show("Bạn cần điền đủ dữ liệu trước khi hoàn tất", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DateTime.Compare(ngsinh, ngBatDau) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu làm phải lớn hơn ngày sinh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isGmail = Regex.IsMatch(staffgmail.Text, @"^([a-zA-Z0-9_\-\.]+)@gmail\.com$");
            if (!isGmail)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng của email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (checkAdmin.Checked)
                {
                    pq = 0;
                }
                else { pq = 1; }
                bool acc = DAL.Account.updateAccount(idacc, pq);
                string start = daystart.Value.Date.ToString("dd/MM/yyyy");
                string birth = staffbirth.Value.Date.ToString("dd/MM/yyyy");
                bool data = DAL.QuanLiNhanVien.updateNhanVien(IDNV, staffname.Text, staffsex.Text, staffgmail.Text, staffphone.Text, birth, staffjob.Text, start);
                MessageBox.Show("Cập nhật thông tin của nhân viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
