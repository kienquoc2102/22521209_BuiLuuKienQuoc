using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    public class Room
    {
        public string name { get; set; }
        public List<List<string>> available_seats { get; set; }
        public List<string> bought_seats { get; set; }
    }
}
