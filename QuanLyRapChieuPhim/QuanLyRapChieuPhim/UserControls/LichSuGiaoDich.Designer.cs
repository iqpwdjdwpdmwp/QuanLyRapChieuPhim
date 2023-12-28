﻿namespace QuanLyRapChieuPhim.UserControls
{
    partial class LichSuGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.productfinding = new Guna.UI2.WinForms.Guna2TextBox();
            this.logs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nggd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giogd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfinding = new Guna.UI2.WinForms.Guna2TextBox();
            this.guestfinding = new Guna.UI2.WinForms.Guna2TextBox();
            this.from = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.to = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logs)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 121);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1206, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // productfinding
            // 
            this.productfinding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productfinding.DefaultText = "";
            this.productfinding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productfinding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productfinding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productfinding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productfinding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productfinding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productfinding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productfinding.Location = new System.Drawing.Point(15, 66);
            this.productfinding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productfinding.Name = "productfinding";
            this.productfinding.PasswordChar = '\0';
            this.productfinding.PlaceholderText = "Tìm tên sản phẩm...";
            this.productfinding.SelectedText = "";
            this.productfinding.Size = new System.Drawing.Size(170, 48);
            this.productfinding.TabIndex = 7;
            this.productfinding.TextChanged += new System.EventHandler(this.productfinding_TextChanged);
            // 
            // logs
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.logs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.logs.ColumnHeadersHeight = 40;
            this.logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.logs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhd,
            this.tensp,
            this.nv,
            this.kh,
            this.quantity,
            this.totalprice,
            this.nggd,
            this.giogd});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logs.DefaultCellStyle = dataGridViewCellStyle11;
            this.logs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.logs.Location = new System.Drawing.Point(15, 137);
            this.logs.Name = "logs";
            this.logs.RowHeadersVisible = false;
            this.logs.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.logs.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.logs.RowTemplate.Height = 30;
            this.logs.Size = new System.Drawing.Size(1171, 626);
            this.logs.TabIndex = 10;
            this.logs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.logs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.logs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.logs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.logs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.logs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.logs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.logs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.logs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.logs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gray;
            this.logs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.logs.ThemeStyle.HeaderStyle.Height = 40;
            this.logs.ThemeStyle.ReadOnly = false;
            this.logs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.logs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.logs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.logs.ThemeStyle.RowsStyle.Height = 30;
            this.logs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.logs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idhd
            // 
            this.idhd.FillWeight = 35F;
            this.idhd.HeaderText = "ID";
            this.idhd.MinimumWidth = 6;
            this.idhd.Name = "idhd";
            // 
            // tensp
            // 
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            this.tensp.DefaultCellStyle = dataGridViewCellStyle9;
            this.tensp.FillWeight = 130F;
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tensp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nv
            // 
            this.nv.HeaderText = "Mã nhân viên";
            this.nv.MinimumWidth = 6;
            this.nv.Name = "nv";
            this.nv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kh
            // 
            this.kh.HeaderText = "Mã khách hàng";
            this.kh.MinimumWidth = 6;
            this.kh.Name = "kh";
            this.kh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 80F;
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalprice
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            this.totalprice.DefaultCellStyle = dataGridViewCellStyle10;
            this.totalprice.HeaderText = "Tổng tiền";
            this.totalprice.MinimumWidth = 6;
            this.totalprice.Name = "totalprice";
            this.totalprice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.totalprice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nggd
            // 
            this.nggd.HeaderText = "Ngày giao dịch";
            this.nggd.MinimumWidth = 6;
            this.nggd.Name = "nggd";
            // 
            // giogd
            // 
            this.giogd.HeaderText = "Giờ giao dịch";
            this.giogd.MinimumWidth = 6;
            this.giogd.Name = "giogd";
            // 
            // empfinding
            // 
            this.empfinding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empfinding.DefaultText = "";
            this.empfinding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empfinding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empfinding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empfinding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empfinding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empfinding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empfinding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empfinding.Location = new System.Drawing.Point(211, 66);
            this.empfinding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empfinding.Name = "empfinding";
            this.empfinding.PasswordChar = '\0';
            this.empfinding.PlaceholderText = "Tìm theo mã nhân viên...";
            this.empfinding.SelectedText = "";
            this.empfinding.Size = new System.Drawing.Size(190, 48);
            this.empfinding.TabIndex = 11;
            // 
            // guestfinding
            // 
            this.guestfinding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guestfinding.DefaultText = "";
            this.guestfinding.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guestfinding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guestfinding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guestfinding.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guestfinding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guestfinding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guestfinding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guestfinding.Location = new System.Drawing.Point(428, 66);
            this.guestfinding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guestfinding.Name = "guestfinding";
            this.guestfinding.PasswordChar = '\0';
            this.guestfinding.PlaceholderText = "Tìm theo mã khách hàng...";
            this.guestfinding.SelectedText = "";
            this.guestfinding.Size = new System.Drawing.Size(200, 48);
            this.guestfinding.TabIndex = 12;
            // 
            // from
            // 
            this.from.Checked = true;
            this.from.CustomFormat = "dd/MM/yyyy";
            this.from.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.from.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.Color.White;
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from.Location = new System.Drawing.Point(721, 66);
            this.from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(152, 48);
            this.from.TabIndex = 42;
            this.from.Value = new System.DateTime(2023, 12, 27, 0, 0, 0, 0);
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // to
            // 
            this.to.Checked = true;
            this.to.CustomFormat = "dd/MM/yyyy";
            this.to.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.to.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.Color.White;
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to.Location = new System.Drawing.Point(984, 66);
            this.to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(152, 48);
            this.to.TabIndex = 43;
            this.to.Value = new System.DateTime(2023, 12, 27, 0, 0, 0, 0);
            this.to.ValueChanged += new System.EventHandler(this.to_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Đến ngày";
            // 
            // LichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.guestfinding);
            this.Controls.Add(this.empfinding);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.productfinding);
            this.Name = "LichSuGiaoDich";
            this.Size = new System.Drawing.Size(1206, 790);
            this.Load += new System.EventHandler(this.LichSuGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox productfinding;
        private Guna.UI2.WinForms.Guna2DataGridView logs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nggd;
        private System.Windows.Forms.DataGridViewTextBoxColumn giogd;
        private Guna.UI2.WinForms.Guna2TextBox empfinding;
        private Guna.UI2.WinForms.Guna2TextBox guestfinding;
        private Guna.UI2.WinForms.Guna2DateTimePicker from;
        private Guna.UI2.WinForms.Guna2DateTimePicker to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
