namespace QuanLyRapChieuPhim.UserControls
{
    partial class DoAn
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.thucan = new Guna.UI2.WinForms.Guna2Button();
            this.thucuong = new Guna.UI2.WinForms.Guna2Button();
            this.tatca = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cart = new System.Windows.Forms.FlowLayoutPanel();
            this.thanhtoanbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalquantity = new System.Windows.Forms.Label();
            this.totalprice = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.thucan);
            this.guna2Panel1.Controls.Add(this.thucuong);
            this.guna2Panel1.Controls.Add(this.tatca);
            this.guna2Panel1.Location = new System.Drawing.Point(62, 51);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(711, 55);
            this.guna2Panel1.TabIndex = 0;
            // 
            // thucan
            // 
            this.thucan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.thucan.BorderRadius = 5;
            this.thucan.BorderThickness = 2;
            this.thucan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.thucan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.thucan.CheckedState.ForeColor = System.Drawing.Color.White;
            this.thucan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thucan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thucan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thucan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thucan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thucan.FillColor = System.Drawing.Color.Transparent;
            this.thucan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thucan.ForeColor = System.Drawing.Color.Black;
            this.thucan.Location = new System.Drawing.Point(508, 5);
            this.thucan.Name = "thucan";
            this.thucan.Size = new System.Drawing.Size(180, 45);
            this.thucan.TabIndex = 2;
            this.thucan.Text = "Đồ ăn";
            this.thucan.Click += new System.EventHandler(this.thucan_Click);
            // 
            // thucuong
            // 
            this.thucuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.thucuong.BorderRadius = 5;
            this.thucuong.BorderThickness = 2;
            this.thucuong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.thucuong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.thucuong.CheckedState.ForeColor = System.Drawing.Color.White;
            this.thucuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thucuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thucuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thucuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thucuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thucuong.FillColor = System.Drawing.Color.Transparent;
            this.thucuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thucuong.ForeColor = System.Drawing.Color.Black;
            this.thucuong.Location = new System.Drawing.Point(265, 5);
            this.thucuong.Name = "thucuong";
            this.thucuong.Size = new System.Drawing.Size(180, 45);
            this.thucuong.TabIndex = 1;
            this.thucuong.Text = "Thức uống";
            this.thucuong.Click += new System.EventHandler(this.thucuong_Click);
            // 
            // tatca
            // 
            this.tatca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tatca.BorderRadius = 5;
            this.tatca.BorderThickness = 2;
            this.tatca.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.tatca.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tatca.CheckedState.ForeColor = System.Drawing.Color.White;
            this.tatca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tatca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tatca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tatca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tatca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tatca.FillColor = System.Drawing.Color.Transparent;
            this.tatca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tatca.ForeColor = System.Drawing.Color.Black;
            this.tatca.Location = new System.Drawing.Point(16, 5);
            this.tatca.Name = "tatca";
            this.tatca.Size = new System.Drawing.Size(180, 45);
            this.tatca.TabIndex = 0;
            this.tatca.Text = "Tất cả";
            this.tatca.Click += new System.EventHandler(this.tatca_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 131);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 694);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cart
            // 
            this.cart.AutoScroll = true;
            this.cart.Location = new System.Drawing.Point(793, 51);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(491, 559);
            this.cart.TabIndex = 3;
            // 
            // thanhtoanbtn
            // 
            this.thanhtoanbtn.BorderRadius = 5;
            this.thanhtoanbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thanhtoanbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thanhtoanbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thanhtoanbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thanhtoanbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thanhtoanbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.thanhtoanbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhtoanbtn.ForeColor = System.Drawing.Color.White;
            this.thanhtoanbtn.Location = new System.Drawing.Point(793, 701);
            this.thanhtoanbtn.Name = "thanhtoanbtn";
            this.thanhtoanbtn.Size = new System.Drawing.Size(476, 71);
            this.thanhtoanbtn.TabIndex = 4;
            this.thanhtoanbtn.Text = "Thanh toán";
            this.thanhtoanbtn.Click += new System.EventHandler(this.thanhtoanbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(789, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng tiền:";
            // 
            // totalquantity
            // 
            this.totalquantity.AutoSize = true;
            this.totalquantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.totalquantity.Location = new System.Drawing.Point(1157, 628);
            this.totalquantity.Name = "totalquantity";
            this.totalquantity.Size = new System.Drawing.Size(20, 23);
            this.totalquantity.TabIndex = 7;
            this.totalquantity.Text = "0";
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.totalprice.Location = new System.Drawing.Point(1157, 665);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(20, 23);
            this.totalprice.TabIndex = 8;
            this.totalprice.Text = "0";
            // 
            // DoAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.totalquantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thanhtoanbtn);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "DoAn";
            this.Size = new System.Drawing.Size(1287, 891);
            this.Load += new System.EventHandler(this.DoAn_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button thucan;
        private Guna.UI2.WinForms.Guna2Button thucuong;
        private Guna.UI2.WinForms.Guna2Button tatca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel cart;
        private Guna.UI2.WinForms.Guna2Button thanhtoanbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalquantity;
        private System.Windows.Forms.Label totalprice;
    }
}
