namespace QuanLyRapChieuPhim.UserControls
{
    partial class QuanLiPhim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.danhsachphim = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphim)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(15, 43);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(393, 48);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 98);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(960, 10);
            this.guna2Separator1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(460, 43);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 49);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // danhsachphim
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.danhsachphim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhsachphim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.danhsachphim.ColumnHeadersHeight = 40;
            this.danhsachphim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhsachphim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphim,
            this.tenphim,
            this.loaiphim,
            this.quocgia,
            this.theloai,
            this.thoiluong});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhsachphim.DefaultCellStyle = dataGridViewCellStyle5;
            this.danhsachphim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.danhsachphim.Location = new System.Drawing.Point(15, 125);
            this.danhsachphim.Name = "danhsachphim";
            this.danhsachphim.RowHeadersVisible = false;
            this.danhsachphim.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.danhsachphim.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.danhsachphim.RowTemplate.Height = 30;
            this.danhsachphim.Size = new System.Drawing.Size(927, 541);
            this.danhsachphim.TabIndex = 3;
            this.danhsachphim.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhsachphim.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhsachphim.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhsachphim.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhsachphim.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhsachphim.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhsachphim.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.danhsachphim.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.danhsachphim.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhsachphim.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachphim.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.danhsachphim.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhsachphim.ThemeStyle.HeaderStyle.Height = 40;
            this.danhsachphim.ThemeStyle.ReadOnly = false;
            this.danhsachphim.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhsachphim.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhsachphim.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachphim.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhsachphim.ThemeStyle.RowsStyle.Height = 30;
            this.danhsachphim.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhsachphim.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhsachphim.SelectionChanged += new System.EventHandler(this.danhsachphim_SelectionChanged);
            // 
            // idphim
            // 
            this.idphim.HeaderText = "IDPHIM";
            this.idphim.MinimumWidth = 6;
            this.idphim.Name = "idphim";
            // 
            // tenphim
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            this.tenphim.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenphim.HeaderText = "Tên phim";
            this.tenphim.MinimumWidth = 6;
            this.tenphim.Name = "tenphim";
            this.tenphim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenphim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // loaiphim
            // 
            this.loaiphim.HeaderText = "Loại phim";
            this.loaiphim.MinimumWidth = 6;
            this.loaiphim.Name = "loaiphim";
            this.loaiphim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.loaiphim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quocgia
            // 
            this.quocgia.HeaderText = "Quốc gia";
            this.quocgia.MinimumWidth = 6;
            this.quocgia.Name = "quocgia";
            this.quocgia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quocgia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // theloai
            // 
            this.theloai.HeaderText = "Thể loại";
            this.theloai.MinimumWidth = 6;
            this.theloai.Name = "theloai";
            this.theloai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.theloai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // thoiluong
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            this.thoiluong.DefaultCellStyle = dataGridViewCellStyle4;
            this.thoiluong.HeaderText = "Thời lượng";
            this.thoiluong.MinimumWidth = 6;
            this.thoiluong.Name = "thoiluong";
            this.thoiluong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.thoiluong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // editBtn
            // 
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Location = new System.Drawing.Point(560, 672);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(109, 42);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(698, 672);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 42);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(833, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(0, 658);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(960, 10);
            this.guna2Separator2.TabIndex = 7;
            // 
            // QuanLiPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.danhsachphim);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2TextBox1);
            this.Name = "QuanLiPhim";
            this.Size = new System.Drawing.Size(960, 726);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView danhsachphim;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn quocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiluong;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}
