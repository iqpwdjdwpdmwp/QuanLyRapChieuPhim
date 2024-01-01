namespace QuanLyRapChieuPhim
{
    partial class SuaSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbEditSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cbbLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btHuyBo = new Guna.UI2.WinForms.Guna2Button();
            this.btHoanTat = new Guna.UI2.WinForms.Guna2Button();
            this.btEditImage = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbLoai);
            this.panel1.Controls.Add(this.lbSoLuong);
            this.panel1.Controls.Add(this.tbSoLuong);
            this.panel1.Controls.Add(this.lbGia);
            this.panel1.Controls.Add(this.tbGia);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.lbEditSP);
            this.panel1.Controls.Add(this.cbbLoaiSP);
            this.panel1.Controls.Add(this.btEditImage);
            this.panel1.Controls.Add(this.btHuyBo);
            this.panel1.Controls.Add(this.btHoanTat);
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 703);
            this.panel1.TabIndex = 0;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = false;
            this.lbLoai.BackColor = System.Drawing.Color.Transparent;
            this.lbLoai.Location = new System.Drawing.Point(39, 324);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(91, 18);
            this.lbLoai.TabIndex = 55;
            this.lbLoai.Text = "Loại ";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = false;
            this.lbSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lbSoLuong.Location = new System.Drawing.Point(39, 248);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(91, 18);
            this.lbSoLuong.TabIndex = 54;
            this.lbSoLuong.Text = "Số lượng ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.BorderColor = System.Drawing.Color.Gray;
            this.tbSoLuong.BorderRadius = 10;
            this.tbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSoLuong.DefaultText = "";
            this.tbSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSoLuong.ForeColor = System.Drawing.Color.Black;
            this.tbSoLuong.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbSoLuong.Location = new System.Drawing.Point(155, 239);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.PasswordChar = '\0';
            this.tbSoLuong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSoLuong.PlaceholderText = "";
            this.tbSoLuong.SelectedText = "";
            this.tbSoLuong.Size = new System.Drawing.Size(326, 33);
            this.tbSoLuong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbSoLuong.TabIndex = 46;
            this.tbSoLuong.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = false;
            this.lbGia.BackColor = System.Drawing.Color.Transparent;
            this.lbGia.Location = new System.Drawing.Point(39, 174);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(91, 18);
            this.lbGia.TabIndex = 52;
            this.lbGia.Text = "Giá tiền";
            // 
            // tbGia
            // 
            this.tbGia.BorderColor = System.Drawing.Color.Gray;
            this.tbGia.BorderRadius = 10;
            this.tbGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGia.DefaultText = "";
            this.tbGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGia.ForeColor = System.Drawing.Color.Black;
            this.tbGia.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbGia.Location = new System.Drawing.Point(155, 166);
            this.tbGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGia.Name = "tbGia";
            this.tbGia.PasswordChar = '\0';
            this.tbGia.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbGia.PlaceholderText = "";
            this.tbGia.SelectedText = "";
            this.tbGia.Size = new System.Drawing.Size(326, 33);
            this.tbGia.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbGia.TabIndex = 45;
            this.tbGia.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // lbName
            // 
            this.lbName.AutoSize = false;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(39, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 18);
            this.lbName.TabIndex = 51;
            this.lbName.Text = "Tên sản phẩm";
            // 
            // tbName
            // 
            this.tbName.BorderColor = System.Drawing.Color.Gray;
            this.tbName.BorderRadius = 10;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(155, 94);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbName.PlaceholderText = "";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(326, 33);
            this.tbName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbName.TabIndex = 44;
            this.tbName.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.SystemColors.ControlDark;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(-1, 60);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(523, 10);
            this.guna2Separator1.TabIndex = 43;
            // 
            // lbEditSP
            // 
            this.lbEditSP.AutoSize = false;
            this.lbEditSP.BackColor = System.Drawing.Color.Transparent;
            this.lbEditSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEditSP.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditSP.Location = new System.Drawing.Point(0, 0);
            this.lbEditSP.Name = "lbEditSP";
            this.lbEditSP.Size = new System.Drawing.Size(521, 48);
            this.lbEditSP.TabIndex = 42;
            this.lbEditSP.Text = "Sửa sản phẩm";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiSP.BorderColor = System.Drawing.Color.Gray;
            this.cbbLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiSP.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiSP.ItemHeight = 30;
            this.cbbLoaiSP.Items.AddRange(new object[] {
            "Đồ ăn",
            "Nước uống"});
            this.cbbLoaiSP.Location = new System.Drawing.Point(155, 310);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(326, 36);
            this.cbbLoaiSP.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbLoaiSP.TabIndex = 47;
            this.cbbLoaiSP.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // btHuyBo
            // 
            this.btHuyBo.AutoRoundedCorners = true;
            this.btHuyBo.BorderRadius = 16;
            this.btHuyBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHuyBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHuyBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHuyBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHuyBo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btHuyBo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btHuyBo.ForeColor = System.Drawing.Color.White;
            this.btHuyBo.Location = new System.Drawing.Point(184, 651);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(137, 34);
            this.btHuyBo.TabIndex = 49;
            this.btHuyBo.Text = "Hủy bỏ";
            // 
            // btHoanTat
            // 
            this.btHoanTat.AutoRoundedCorners = true;
            this.btHoanTat.BorderRadius = 16;
            this.btHoanTat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHoanTat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHoanTat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHoanTat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHoanTat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btHoanTat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btHoanTat.ForeColor = System.Drawing.Color.White;
            this.btHoanTat.Location = new System.Drawing.Point(344, 651);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(137, 34);
            this.btHoanTat.TabIndex = 50;
            this.btHoanTat.Text = "Hoàn tất";
            // 
            // btEditImage
            // 
            this.btEditImage.AutoRoundedCorners = true;
            this.btEditImage.BorderColor = System.Drawing.Color.DimGray;
            this.btEditImage.BorderRadius = 21;
            this.btEditImage.BorderThickness = 1;
            this.btEditImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btEditImage.ForeColor = System.Drawing.Color.White;
            this.btEditImage.Image = global::QuanLyRapChieuPhim.Properties.Resources.InsertFileIcon;
            this.btEditImage.Location = new System.Drawing.Point(388, 461);
            this.btEditImage.Name = "btEditImage";
            this.btEditImage.Size = new System.Drawing.Size(60, 45);
            this.btEditImage.TabIndex = 48;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.ImageRotate = 0F;
            this.pictureBoxImage.Location = new System.Drawing.Point(39, 392);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBoxImage.Size = new System.Drawing.Size(282, 200);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 53;
            this.pictureBoxImage.TabStop = false;
            // 
            // SuaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 703);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuaSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaSP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox tbSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbGia;
        private Guna.UI2.WinForms.Guna2TextBox tbGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbEditSP;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btEditImage;
        private Guna.UI2.WinForms.Guna2Button btHuyBo;
        private Guna.UI2.WinForms.Guna2Button btHoanTat;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImage;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}