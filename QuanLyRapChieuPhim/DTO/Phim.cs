﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Phim
    {
        public int id { get; set; }
        public string tenphim { get; set; }
        public string dangphim { get; set; }
        public string theloai { get; set; }
        public string quocgia { get; set; }
        public string moviePic { get; set; }
        public string thoiluong { get; set; }
        
        public string namphathanh { get; set; }
        public string tacgia { get; set; }
        public string mota { get; set; }

        public Phim()
        {
            id = 0;
            tenphim = string.Empty;
            dangphim = string.Empty;
            theloai = string.Empty;
            quocgia = string.Empty;
            moviePic = string.Empty;
            thoiluong = string.Empty;
        }
    }
}
