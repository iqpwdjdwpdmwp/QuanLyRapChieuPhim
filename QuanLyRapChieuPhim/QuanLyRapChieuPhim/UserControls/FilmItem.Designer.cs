namespace QuanLyRapChieuPhim.UserControls
{
    partial class FilmItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmItem));
            this.tenphim = new System.Windows.Forms.Label();
            this.properties = new System.Windows.Forms.Label();
            this.mota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.datvebtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tenphim
            // 
            this.tenphim.AutoSize = true;
            this.tenphim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenphim.ForeColor = System.Drawing.Color.White;
            this.tenphim.Location = new System.Drawing.Point(15, 192);
            this.tenphim.Name = "tenphim";
            this.tenphim.Size = new System.Drawing.Size(181, 23);
            this.tenphim.TabIndex = 1;
            this.tenphim.Text = "Avengers - End game";
            // 
            // properties
            // 
            this.properties.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.properties.ForeColor = System.Drawing.Color.White;
            this.properties.Location = new System.Drawing.Point(15, 223);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(283, 41);
            this.properties.TabIndex = 2;
            this.properties.Text = "12 | 3h 1min | Action, Adventure, Drama | 2019";
            // 
            // mota
            // 
            this.mota.AllowDrop = true;
            this.mota.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mota.ForeColor = System.Drawing.Color.White;
            this.mota.Location = new System.Drawing.Point(16, 265);
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(269, 72);
            this.mota.TabIndex = 3;
            this.mota.Text = resources.GetString("mota.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // datvebtn
            // 
            this.datvebtn.BorderColor = System.Drawing.Color.Empty;
            this.datvebtn.BorderRadius = 5;
            this.datvebtn.BorderThickness = 1;
            this.datvebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datvebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.datvebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.datvebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.datvebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.datvebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.datvebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datvebtn.ForeColor = System.Drawing.Color.White;
            this.datvebtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.datvebtn.Location = new System.Drawing.Point(42, 346);
            this.datvebtn.Name = "datvebtn";
            this.datvebtn.Size = new System.Drawing.Size(216, 32);
            this.datvebtn.TabIndex = 4;
            this.datvebtn.Text = "Đặt vé ngay";
            this.datvebtn.Click += new System.EventHandler(this.datvebtn_Click);
            // 
            // FilmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.datvebtn);
            this.Controls.Add(this.mota);
            this.Controls.Add(this.properties);
            this.Controls.Add(this.tenphim);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 0, 25);
            this.Name = "FilmItem";
            this.Size = new System.Drawing.Size(300, 398);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tenphim;
        private System.Windows.Forms.Label properties;
        private System.Windows.Forms.Label mota;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button datvebtn;
    }
}
