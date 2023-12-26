namespace QuanLyRapChieuPhim
{
    partial class KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.namelb = new Guna.UI2.WinForms.Guna2TextBox();
            this.emaillb = new Guna.UI2.WinForms.Guna2TextBox();
            this.phonelb = new Guna.UI2.WinForms.Guna2TextBox();
            this.addresslb = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateborn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateregister = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // namelb
            // 
            this.namelb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namelb.DefaultText = "";
            this.namelb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.namelb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.namelb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namelb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namelb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.namelb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.namelb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.namelb.Location = new System.Drawing.Point(276, 94);
            this.namelb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namelb.Name = "namelb";
            this.namelb.PasswordChar = '\0';
            this.namelb.PlaceholderText = "Tên khách hàng";
            this.namelb.SelectedText = "";
            this.namelb.Size = new System.Drawing.Size(229, 48);
            this.namelb.TabIndex = 1;
            // 
            // emaillb
            // 
            this.emaillb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emaillb.DefaultText = "";
            this.emaillb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emaillb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emaillb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emaillb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emaillb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emaillb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emaillb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emaillb.Location = new System.Drawing.Point(276, 150);
            this.emaillb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emaillb.Name = "emaillb";
            this.emaillb.PasswordChar = '\0';
            this.emaillb.PlaceholderText = "Email";
            this.emaillb.SelectedText = "";
            this.emaillb.Size = new System.Drawing.Size(229, 48);
            this.emaillb.TabIndex = 2;
            // 
            // phonelb
            // 
            this.phonelb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonelb.DefaultText = "";
            this.phonelb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonelb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonelb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonelb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonelb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonelb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonelb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonelb.Location = new System.Drawing.Point(276, 206);
            this.phonelb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonelb.Name = "phonelb";
            this.phonelb.PasswordChar = '\0';
            this.phonelb.PlaceholderText = "Số điện thoại";
            this.phonelb.SelectedText = "";
            this.phonelb.Size = new System.Drawing.Size(229, 48);
            this.phonelb.TabIndex = 3;
            // 
            // addresslb
            // 
            this.addresslb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresslb.DefaultText = "";
            this.addresslb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addresslb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addresslb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresslb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresslb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresslb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addresslb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresslb.Location = new System.Drawing.Point(276, 262);
            this.addresslb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addresslb.Name = "addresslb";
            this.addresslb.PasswordChar = '\0';
            this.addresslb.PlaceholderText = "Địa chỉ";
            this.addresslb.SelectedText = "";
            this.addresslb.Size = new System.Drawing.Size(229, 48);
            this.addresslb.TabIndex = 4;
            // 
            // dateborn
            // 
            this.dateborn.Checked = true;
            this.dateborn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateborn.ForeColor = System.Drawing.Color.White;
            this.dateborn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateborn.Location = new System.Drawing.Point(535, 115);
            this.dateborn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateborn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateborn.Name = "dateborn";
            this.dateborn.Size = new System.Drawing.Size(229, 46);
            this.dateborn.TabIndex = 5;
            this.dateborn.Value = new System.DateTime(2023, 12, 25, 22, 46, 17, 40);
            // 
            // dateregister
            // 
            this.dateregister.Checked = true;
            this.dateregister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateregister.ForeColor = System.Drawing.Color.White;
            this.dateregister.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateregister.Location = new System.Drawing.Point(535, 208);
            this.dateregister.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateregister.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateregister.Name = "dateregister";
            this.dateregister.Size = new System.Drawing.Size(229, 46);
            this.dateregister.TabIndex = 6;
            this.dateregister.Value = new System.DateTime(2023, 12, 25, 22, 46, 17, 40);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày đăng kí";
            // 
            // submitbtn
            // 
            this.submitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.Location = new System.Drawing.Point(276, 337);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(229, 50);
            this.submitbtn.TabIndex = 9;
            this.submitbtn.Text = "Thêm khách hàng";
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male.CheckedState.BorderThickness = 0;
            this.male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.male.CheckedState.InnerOffset = -4;
            this.male.Location = new System.Drawing.Point(168, 178);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(57, 20);
            this.male.TabIndex = 11;
            this.male.Text = "Nam";
            this.male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.male.UncheckedState.BorderThickness = 2;
            this.male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female.CheckedState.BorderThickness = 0;
            this.female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.female.CheckedState.InnerOffset = -4;
            this.female.Location = new System.Drawing.Point(168, 219);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(45, 20);
            this.female.TabIndex = 12;
            this.female.Text = "Nữ";
            this.female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.female.UncheckedState.BorderThickness = 2;
            this.female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giới tính";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateregister);
            this.Controls.Add(this.dateborn);
            this.Controls.Add(this.addresslb);
            this.Controls.Add(this.phonelb);
            this.Controls.Add(this.emaillb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox namelb;
        private Guna.UI2.WinForms.Guna2TextBox emaillb;
        private Guna.UI2.WinForms.Guna2TextBox phonelb;
        private Guna.UI2.WinForms.Guna2TextBox addresslb;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateborn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button submitbtn;
        private Guna.UI2.WinForms.Guna2RadioButton male;
        private Guna.UI2.WinForms.Guna2RadioButton female;
        private System.Windows.Forms.Label label4;
    }
}