using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Library
    {
        public Book[] books = new Book[3];
        //public Magazine[] magazines;
        //public Encyclopaedia[] encs;
        public ReadingRooms[] ReservedRooms = new ReadingRooms[3];

        public void AddBook(Book b)
        {

            //Array.Resize(ref books, Book.Quantity);
            for (int i = 0; i < books.Length; i++)
            {

                if (books[i] != null)
                {
                    if(books[i].SerialNumber == b.SerialNumber)
                    {
                        throw new ArgumentException("There is in the library the book which has the serial number you input.");
                    }
                }
                books[i] = b;
            }

            //foreach (var book in books)
            //{
            //    var result = books.Distinct().ToArray();
            //    Console.WriteLine(result);
            //}












            //public void AddMagazine(Magazine m)
            //{

            //}
            //public void AddEncyclopaedia(Encyclopaedia e)
            //{

            //}


        }

        public void ReserveReadingRooms(ReadingRooms r, DateTime time)
        {
            //Array.Resize(ref ReservedRooms, ReadingRooms.Counter);
            for (int i = 0; i < ReservedRooms.Length; i++)
            {
                if (r.Status == "available for using")
                {
                    r.Status = "reserved";
                    r.Time = time;
                    Console.WriteLine($"Your order has been accepted for {time}");
                }
                else
                {
                    Console.WriteLine("Sorry, the room you want to reserve had already been ordered by another customer.");
                }
                ReservedRooms[i] = r;
            }
        }
    }
}
