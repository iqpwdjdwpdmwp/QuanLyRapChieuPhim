namespace QuanLyRapChieuPhim.UserControls
{
    partial class PhimDangChieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.danhsachtheloai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.datefinding = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.danhsachthoiluong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.danhsachquocgia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.find = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phim đang chiếu";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 107);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1218, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // danhsachtheloai
            // 
            this.danhsachtheloai.AutoRoundedCorners = true;
            this.danhsachtheloai.BackColor = System.Drawing.Color.Transparent;
            this.danhsachtheloai.BorderRadius = 17;
            this.danhsachtheloai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.danhsachtheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.danhsachtheloai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachtheloai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachtheloai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.danhsachtheloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.danhsachtheloai.ItemHeight = 30;
            this.danhsachtheloai.Items.AddRange(new object[] {
            "Tất cả",
            "Hành động",
            "Hài",
            "Âm nhạc",
            "Bí ẩn",
            "Chiến tranh",
            "Chính kịch",
            "Gia đình",
            "Hoạt hình",
            "Tài liệu",
            "Lịch sử"});
            this.danhsachtheloai.Location = new System.Drawing.Point(503, 38);
            this.danhsachtheloai.Name = "danhsachtheloai";
            this.danhsachtheloai.Size = new System.Drawing.Size(174, 36);
            this.danhsachtheloai.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1229, 716);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.guna2Panel1.Controls.Add(this.find);
            this.guna2Panel1.Controls.Add(this.datefinding);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.danhsachthoiluong);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.danhsachquocgia);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.danhsachtheloai);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1306, 117);
            this.guna2Panel1.TabIndex = 6;
            // 
            // datefinding
            // 
            this.datefinding.AutoRoundedCorners = true;
            this.datefinding.BorderRadius = 17;
            this.datefinding.Checked = true;
            this.datefinding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datefinding.ForeColor = System.Drawing.Color.White;
            this.datefinding.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datefinding.Location = new System.Drawing.Point(216, 43);
            this.datefinding.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datefinding.MinDate = new System.DateTime(2023, 12, 30, 0, 0, 0, 0);
            this.datefinding.Name = "datefinding";
            this.datefinding.Size = new System.Drawing.Size(270, 36);
            this.datefinding.TabIndex = 9;
            this.datefinding.Value = new System.DateTime(2023, 12, 30, 0, 0, 0, 0);
            this.datefinding.ValueChanged += new System.EventHandler(this.datefinding_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(936, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời lượng";
            // 
            // danhsachthoiluong
            // 
            this.danhsachthoiluong.AutoRoundedCorners = true;
            this.danhsachthoiluong.BackColor = System.Drawing.Color.Transparent;
            this.danhsachthoiluong.BorderRadius = 17;
            this.danhsachthoiluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.danhsachthoiluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.danhsachthoiluong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachthoiluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachthoiluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.danhsachthoiluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.danhsachthoiluong.ItemHeight = 30;
            this.danhsachthoiluong.Items.AddRange(new object[] {
            "Tất cả",
            "Dưới 1 tiếng",
            "Dưới 2 tiếng",
            "Dưới 3 tiếng",
            "Dưới 4 tiếng"});
            this.danhsachthoiluong.Location = new System.Drawing.Point(939, 38);
            this.danhsachthoiluong.Name = "danhsachthoiluong";
            this.danhsachthoiluong.Size = new System.Drawing.Size(174, 36);
            this.danhsachthoiluong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(712, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quốc gia";
            // 
            // danhsachquocgia
            // 
            this.danhsachquocgia.AutoRoundedCorners = true;
            this.danhsachquocgia.BackColor = System.Drawing.Color.Transparent;
            this.danhsachquocgia.BorderRadius = 17;
            this.danhsachquocgia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.danhsachquocgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.danhsachquocgia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachquocgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachquocgia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.danhsachquocgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.danhsachquocgia.ItemHeight = 30;
            this.danhsachquocgia.Items.AddRange(new object[] {
            "Tất cả",
            "Mỹ",
            "Hàn Quốc",
            "Anh",
            "Việt Nam"});
            this.danhsachquocgia.Location = new System.Drawing.Point(715, 38);
            this.danhsachquocgia.Name = "danhsachquocgia";
            this.danhsachquocgia.Size = new System.Drawing.Size(174, 36);
            this.danhsachquocgia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(500, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thể loại";
            // 
            // find
            // 
            this.find.AutoRoundedCorners = true;
            this.find.BorderRadius = 23;
            this.find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.find.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.find.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.find.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.ForeColor = System.Drawing.Color.White;
            this.find.Location = new System.Drawing.Point(1140, 33);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(134, 48);
            this.find.TabIndex = 10;
            this.find.Text = "Tìm kiếm";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // PhimDangChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Separator1);
            this.Name = "PhimDangChieu";
            this.Size = new System.Drawing.Size(1306, 891);
            this.Load += new System.EventHandler(this.PhimDangChieu_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox danhsachtheloai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox danhsachthoiluong;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox danhsachquocgia;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker datefinding;
        private Guna.UI2.WinForms.Guna2Button find;
    }
}
