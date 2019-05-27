using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class ReadingRooms
    {
        public string Name { get; set; }
        public string Id { get; private set; }
        public string Status { get; set; } = "available for using";
        public DateTime Time { get; set; }
        public static int Counter { get; private set; } = 1;
        public ReadingRooms()
        {
            string result;
            if(Counter > 0 && Counter < 10)
            {
                result = "00" + Counter;
            }
            else if(Counter >= 10 && Counter < 100)
            {
                result = "0" + Counter;
            }
            else
            {
                result = Counter.ToString();
            }

            Id = result;
            Counter++;
        }
    }
}
