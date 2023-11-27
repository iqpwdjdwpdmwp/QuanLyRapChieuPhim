using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Phim
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string genre { get; set; }
        public string country { get; set; }
        public string moviePic { get; set; }
        public int duration { get; set; }

        public Phim()
        {
            id = 0;
            name = string.Empty;
            type = string.Empty;
            genre = string.Empty;
            country = string.Empty;
            moviePic = string.Empty;
            duration = 0;
        }
    }
}
