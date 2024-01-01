namespace QuanLyRapChieuPhim
{
    partial class ThemSuatChieu
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
            this.ngaychieupicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxHour = new Guna.UI2.WinForms.Guna2ComboBox();
            this.phongchieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxFilm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btHuyBo = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btHoanTat = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ngaychieupicker
            // 
            this.ngaychieupicker.Checked = true;
            this.ngaychieupicker.CustomFormat = "dd/MM/yyyy";
            this.ngaychieupicker.FillColor = System.Drawing.Color.Black;
            this.ngaychieupicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngaychieupicker.ForeColor = System.Drawing.Color.White;
            this.ngaychieupicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaychieupicker.Location = new System.Drawing.Point(154, 495);
            this.ngaychieupicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaychieupicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaychieupicker.Name = "ngaychieupicker";
            this.ngaychieupicker.Size = new System.Drawing.Size(375, 36);
            this.ngaychieupicker.TabIndex = 48;
            this.ngaychieupicker.Value = new System.DateTime(2023, 11, 6, 7, 52, 25, 300);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxHour);
            this.panel1.Controls.Add(this.phongchieu);
            this.panel1.Controls.Add(this.ngaychieupicker);
            this.panel1.Controls.Add(this.comboBoxFilm);
            this.panel1.Controls.Add(this.btHuyBo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.lblHoten);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblGmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.btHoanTat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 750);
            this.panel1.TabIndex = 47;
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxHour.BorderColor = System.Drawing.Color.DimGray;
            this.comboBoxHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHour.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxHour.ForeColor = System.Drawing.Color.Black;
            this.comboBoxHour.ItemHeight = 32;
            this.comboBoxHour.Location = new System.Drawing.Point(154, 339);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(375, 38);
            this.comboBoxHour.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxHour.TabIndex = 47;
            // 
            // phongchieu
            // 
            this.phongchieu.BorderColor = System.Drawing.Color.DimGray;
            this.phongchieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phongchieu.DefaultText = "";
            this.phongchieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phongchieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phongchieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phongchieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phongchieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phongchieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phongchieu.ForeColor = System.Drawing.Color.Black;
            this.phongchieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phongchieu.Location = new System.Drawing.Point(154, 218);
            this.phongchieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phongchieu.Name = "phongchieu";
            this.phongchieu.PasswordChar = '\0';
            this.phongchieu.PlaceholderText = "";
            this.phongchieu.SelectedText = "";
            this.phongchieu.Size = new System.Drawing.Size(375, 37);
            this.phongchieu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phongchieu.TabIndex = 46;
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxFilm.BorderColor = System.Drawing.Color.DimGray;
            this.comboBoxFilm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFilm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFilm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxFilm.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFilm.ItemHeight = 32;
            this.comboBoxFilm.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxFilm.Location = new System.Drawing.Point(154, 85);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(375, 38);
            this.comboBoxFilm.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxFilm.TabIndex = 45;
            // 
            // btHuyBo
            // 
            this.btHuyBo.BackColor = System.Drawing.Color.White;
            this.btHuyBo.BorderRadius = 10;
            this.btHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuyBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHuyBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHuyBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHuyBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHuyBo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btHuyBo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btHuyBo.ForeColor = System.Drawing.Color.White;
            this.btHuyBo.Location = new System.Drawing.Point(195, 658);
            this.btHuyBo.Name = "btHuyBo";
            this.btHuyBo.Size = new System.Drawing.Size(154, 36);
            this.btHuyBo.TabIndex = 29;
            this.btHuyBo.Text = "Hủy bỏ";
            this.btHuyBo.Click += new System.EventHandler(this.btHuyBo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 38);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thêm suất chiếu";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(-1, 40);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(556, 10);
            this.guna2Separator1.TabIndex = 44;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(15, 94);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(70, 20);
            this.lblHoten.TabIndex = 20;
            this.lblHoten.Text = "Tên phim";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(15, 227);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(90, 20);
            this.lblSex.TabIndex = 23;
            this.lblSex.Text = "Phòng chiếu";
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGmail.Location = new System.Drawing.Point(15, 495);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(83, 20);
            this.lblGmail.TabIndex = 27;
            this.lblGmail.Text = "Ngày chiếu";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(15, 350);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 20);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "Giờ chiếu";
            // 
            // btHoanTat
            // 
            this.btHoanTat.BackColor = System.Drawing.Color.White;
            this.btHoanTat.BorderRadius = 10;
            this.btHoanTat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHoanTat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHoanTat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHoanTat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHoanTat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHoanTat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btHoanTat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btHoanTat.ForeColor = System.Drawing.Color.White;
            this.btHoanTat.Location = new System.Drawing.Point(375, 658);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(154, 36);
            this.btHoanTat.TabIndex = 30;
            this.btHoanTat.Text = "Hoàn tất";
            this.btHoanTat.Click += new System.EventHandler(this.btHoanTat_Click);
            // 
            // ThemSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 750);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemSuatChieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemSuatChieu";
            this.Load += new System.EventHandler(this.ThemSuatChieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker ngaychieupicker;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btHuyBo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI2.WinForms.Guna2Button btHoanTat;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHour;
        private Guna.UI2.WinForms.Guna2TextBox phongchieu;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilm;
    }
}