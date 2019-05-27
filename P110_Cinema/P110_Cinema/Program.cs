using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema(3);

            Hall dolbyRoom = new Hall(5, 10);
            cinema.AddHall(dolbyRoom);

            Hall bakcellRoom = new Hall(3, 7);
            cinema.AddHall(bakcellRoom);

            Hall interRoom = new Hall(5, 5);
            cinema.AddHall(interRoom);

            //Hall errorRoom = new Hall(4, 4);
            //cinema.AddHall(errorRoom);

            dolbyRoom.Reserve(3, 3);
            dolbyRoom.Reserve(6, 3);
            dolbyRoom.Reserve(3, 3);
            dolbyRoom.Release(3, 3);
            dolbyRoom.Buy(3, 3);
        }
    }
}
