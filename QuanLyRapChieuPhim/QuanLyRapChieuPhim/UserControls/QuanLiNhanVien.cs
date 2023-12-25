using DTO;
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
    public partial class QuanLiNhanVien : UserControl
    {
        private DataTable data;
        NV staff = new NV();
        public int IDNV { get; set; }
        public QuanLiNhanVien()
        {
            InitializeComponent();
            getAllStaff();
        }
        private void getAllStaff()
        {
            data = DAL.QuanLiNhanVien.getAllStaff();
            danhsachnv.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                staff.id = Convert.ToInt32(row["IDNV"]);
                staff.hotennv = row["HOTEN"].ToString();
                staff.gioitinhnv = row["GIOITINH"].ToString();
                staff.emailnv = row["EMAIL"].ToString();
                staff.sdtnv = row["SDT"].ToString();
                staff.ngaysinhnv = row["NGAYSINH"].ToString();
                staff.chucvunv = row["CHUCVU"].ToString();
                staff.ngayvaolam = row["NGAYBD"].ToString();
                danhsachnv.Rows.Add(new object[]
                {
                    staff.id,
                    staff.hotennv,
                    staff.gioitinhnv,
                    staff.emailnv,
                    staff.sdtnv,
                    staff.ngaysinhnv,
                    staff.chucvunv,
                    staff.ngayvaolam
                });
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemNV newForm = new ThemNV();
            newForm.Show();
        }

        private void danhsachnv_SelectionChanged(object sender, EventArgs e)
        {
            if (danhsachnv.SelectedRows.Count > 0)
            {
                int selectedrowindex = danhsachnv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = danhsachnv.Rows[selectedrowindex];
                IDNV = Convert.ToInt32(selectedRow.Cells["IDNV"].Value);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool data = DAL.QuanLiNhanVien.deleteNhanVien(IDNV);
                //string img = phim.moviePic;
                //File.Delete(img);
                MessageBox.Show("Xóa nhân viên thành công");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            SuaNV newForm = new SuaNV(IDNV);
            newForm.Show();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            getAllStaff();
        }
    }
}
