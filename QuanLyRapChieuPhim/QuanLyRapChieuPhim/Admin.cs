﻿using QuanLyRapChieuPhim.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapChieuPhim
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }



        

        

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            QuanLiPhim newForm = new QuanLiPhim();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLiSuatChieu newForm = new QuanLiSuatChieu();
            panel2.Controls.Clear();
            panel2.Controls.Add((newForm));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            QuanLiDoAn newForm = new QuanLiDoAn();
            panel2.Controls.Clear();
            panel2.Controls.Add(newForm);
        }
    }
}
