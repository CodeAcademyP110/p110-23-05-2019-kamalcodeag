using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Magazine
    {
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Magazine(int serial)
        {
            SerialNumber = serial;
        }
    }
}
