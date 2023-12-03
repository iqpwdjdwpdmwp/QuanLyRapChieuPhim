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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.danhsachtheloai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 42);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(685, 41);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(281, 37);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // danhsachtheloai
            // 
            this.danhsachtheloai.BackColor = System.Drawing.Color.Transparent;
            this.danhsachtheloai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.danhsachtheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.danhsachtheloai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachtheloai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.danhsachtheloai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.danhsachtheloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.danhsachtheloai.ItemHeight = 30;
            this.danhsachtheloai.Items.AddRange(new object[] {
            "Hành động",
            "Hài",
            "Âm nhạc",
            "Bí ẩn",
            "Chiến tranh",
            "Chính kịch",
            "Gia đình"});
            this.danhsachtheloai.Location = new System.Drawing.Point(1044, 42);
            this.danhsachtheloai.Name = "danhsachtheloai";
            this.danhsachtheloai.Size = new System.Drawing.Size(174, 36);
            this.danhsachtheloai.TabIndex = 3;
            this.danhsachtheloai.SelectedIndexChanged += new System.EventHandler(this.danhsachtheloai_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1173, 716);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // PhimDangChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.danhsachtheloai);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Name = "PhimDangChieu";
            this.Size = new System.Drawing.Size(1287, 891);
            this.Load += new System.EventHandler(this.PhimDangChieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox danhsachtheloai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
