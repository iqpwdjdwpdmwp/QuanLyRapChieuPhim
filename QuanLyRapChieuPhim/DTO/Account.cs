using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Account
    {
        public int id { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public int Phanquyen { get; set; }
        public Account()
        {
            id = 0;
            TenDN=string.Empty;
            MatKhau=string.Empty;
            Phanquyen = 0;
        }
    }
}
