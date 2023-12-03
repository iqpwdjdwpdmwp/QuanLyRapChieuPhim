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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilm = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ngaychieupicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.phongchieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxHour = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thêm suất chiếu";
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxFilm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilm.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFilm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFilm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxFilm.ItemHeight = 30;
            this.comboBoxFilm.Location = new System.Drawing.Point(68, 114);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(184, 36);
            this.comboBoxFilm.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày chiếu";
            // 
            // ngaychieupicker
            // 
            this.ngaychieupicker.Checked = true;
            this.ngaychieupicker.CustomFormat = "dd/MM/yyyy";
            this.ngaychieupicker.FillColor = System.Drawing.Color.Black;
            this.ngaychieupicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngaychieupicker.ForeColor = System.Drawing.Color.White;
            this.ngaychieupicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaychieupicker.Location = new System.Drawing.Point(607, 114);
            this.ngaychieupicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaychieupicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaychieupicker.Name = "ngaychieupicker";
            this.ngaychieupicker.Size = new System.Drawing.Size(219, 36);
            this.ngaychieupicker.TabIndex = 18;
            this.ngaychieupicker.Value = new System.DateTime(2023, 11, 6, 7, 52, 25, 300);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phòng chiếu";
            // 
            // phongchieu
            // 
            this.phongchieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phongchieu.DefaultText = "";
            this.phongchieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phongchieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phongchieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phongchieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phongchieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phongchieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phongchieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phongchieu.Location = new System.Drawing.Point(70, 233);
            this.phongchieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phongchieu.Name = "phongchieu";
            this.phongchieu.PasswordChar = '\0';
            this.phongchieu.PlaceholderText = "";
            this.phongchieu.SelectedText = "";
            this.phongchieu.Size = new System.Drawing.Size(96, 38);
            this.phongchieu.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giờ chiếu";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(607, 393);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(204, 45);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Xác nhận";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHour.DropDownHeight = 150;
            this.comboBoxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHour.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxHour.IntegralHeight = false;
            this.comboBoxHour.ItemHeight = 30;
            this.comboBoxHour.Location = new System.Drawing.Point(607, 233);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(184, 36);
            this.comboBoxHour.TabIndex = 26;
            // 
            // ThemSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 467);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phongchieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ngaychieupicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemSuatChieu";
            this.Text = "ThemSuatChieu";
            this.Load += new System.EventHandler(this.ThemSuatChieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFilm;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngaychieupicker;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox phongchieu;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHour;
    }
}