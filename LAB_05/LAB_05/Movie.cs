using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LAB_05.FormBT4;

namespace LAB_05
{
    public class Movie
    {
        public string MovieName { get; set; }
        public string MovieUrl { get; set; }
        public string MovieImg { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
