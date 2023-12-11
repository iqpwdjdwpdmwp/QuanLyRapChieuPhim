using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NV
    {
        public int id { get; set; }
        public string hotennv { get; set; }
        public string gioitinhnv { get; set; }
        public string emailnv { get; set; }
        public string sdtnv { get; set; }
        public string ngaysinhnv { get; set; }
        public string chucvunv { get; set; }
        public string ngayvaolam { get; set; }
        public NV()
        {
            id = 0;
            hotennv = string.Empty;
            gioitinhnv = string.Empty;
            emailnv = string.Empty;
            sdtnv = string.Empty;
            ngaysinhnv = string.Empty;
            chucvunv = string.Empty;
            ngayvaolam = string.Empty;
        }
    }
}
