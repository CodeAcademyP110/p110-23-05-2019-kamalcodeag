using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_Cinema
{
    public class Cinema
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string ShortInfo { get; set; }

        private int HallIndex = 0;

        //public Hall[] Halls { get; private set; }
        private readonly Hall[] halls;

        public Cinema(int hallCount)
        {
            halls = new Hall[hallCount];
        }

        public void AddHall(Hall hall)
        {
            if(HallIndex < halls.Length)
            {
                halls[HallIndex++] = hall;
            }
            else
            {
                throw new Exception("There is no place for new Hall");
            }
            //for (int i = 0; i < halls.Length; i++)
            //{
            //    if(halls[i] == null)
            //    {
            //        halls[i] = hall;
            //        break;
            //    }
            //}
        }
        
    }
}
