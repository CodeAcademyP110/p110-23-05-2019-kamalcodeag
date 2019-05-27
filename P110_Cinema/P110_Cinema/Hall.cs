using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P110_Cinema
{
    public class Hall
    {
        private static int HallIdCounter = 1;

        public string Name { get; set; }
        public string Id { get; set; }
        public bool IsPremium { get; set; }
        public string ScreenType { get; set; }
        //private int RowCount;
        //private int ColumnCount;
        private readonly Seat[,] seats;

        public Hall(int rowCount, int colCount)
        {
            //fill hall with seats
            seats = new Seat[rowCount, colCount];
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    //Seat seat = new Seat();
                    //seat.RowNo = i + 1;
                    //seat.ColNo = j + 1;
                    //seat.State = "empty";
                    //seats[i, j] = seat;

                    seats[i, j] = new Seat {
                        RowNo = i + 1,
                        ColNo = j + 1,
                        State = "empty"
                    };
                }
            }

            //give unique Id to Hall
            string id = HallIdCounter < 10 ? "0" + HallIdCounter : HallIdCounter.ToString();
            Id = id;
            HallIdCounter++;
        }

        public void Reserve(int rowNo, int colNo)
        {
            if(rowNo < seats.GetLength(0) && colNo < seats.GetLength(1))
            {
                Seat selectedSeat = seats[rowNo, colNo];
                if (selectedSeat.State == "empty")
                {
                    selectedSeat.State = "reserved";
                    Console.WriteLine($"Hall: {Name}; Seat: {selectedSeat.RowNo}, {selectedSeat.ColNo} reserved.");
                }
                else
                {
                    //throw new ArgumentException(){ "" };
                    Console.WriteLine($"Hall: {Name}; Seat: {selectedSeat.RowNo}, {selectedSeat.ColNo} has already been reserved.");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("There is no seat on this row and column in this hall");
            }
            
        }

        public void Release(int rowNo, int colNo)
        {
            //check rowNo and colNo
            Seat selectedSeat = seats[rowNo, colNo];

            if(selectedSeat.State == "full")
            {
                Console.WriteLine($"Hall: {Name}; Seat: {selectedSeat.RowNo}, {selectedSeat.ColNo} can not be released. It has been bought.");
            }
            else
            {
                selectedSeat.State = "empty";
                Console.WriteLine($"Hall: {Name}; Seat: {selectedSeat.RowNo}, {selectedSeat.ColNo} was released.");
            }
        }

        public void Buy(int rowNo, int colNo)
        {
            //check rowNo and colNo
            Seat selectedSeat = seats[rowNo, colNo];
            if (selectedSeat.State != "full")
            {
                selectedSeat.State = "full";
                Console.WriteLine($"Hall: {Name}; Seat: {selectedSeat.RowNo}, {selectedSeat.ColNo} was bought.");
            }
            else
            {
                //throw new ArgumentException(){ "" };
                Console.WriteLine($"Hall: {Name}; Seat: {selectedSeat.RowNo}, {selectedSeat.ColNo} has already been bought.");
            }
        }
    }
}
