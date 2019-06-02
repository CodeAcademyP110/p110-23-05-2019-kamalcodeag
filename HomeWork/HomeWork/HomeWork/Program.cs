using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First Task

            Library library = new Library();

            Book book = new Book("A", 123456, "detective", "ali", 12, true, 25);
            library.AddBook(book);

            Book book2 = new Book("B", 123456, "philosophy", "will", 8, false);
            library.AddBook(book2);

            Book book3 = new Book("C", 115599, "utopic", "ryan", 18, true, 40);
            library.AddBook(book3);


            Console.WriteLine(Book.Quantity);

            Console.WriteLine(book.Name);
            Console.WriteLine(book2.Name);
            Console.WriteLine(book3.Name);

            Console.WriteLine(book.SerialNumber);
            Console.WriteLine(book2.SerialNumber);
            Console.WriteLine(book3.SerialNumber);

            Console.WriteLine(book.Genre);
            Console.WriteLine(book2.Genre);
            Console.WriteLine(book3.Genre);

            Console.WriteLine(book.Author);
            Console.WriteLine(book2.Author);
            Console.WriteLine(book3.Author);

            Console.WriteLine(book.Price);
            Console.WriteLine(book2.Price);
            Console.WriteLine(book3.Price);

            //Console.WriteLine(book.ActualPrice);
            //Console.WriteLine(book2.ActualPrice);
            //Console.WriteLine(book3.ActualPrice);

            Console.WriteLine(book.GetActualPrice());
            Console.WriteLine(book2.GetActualPrice());
            Console.WriteLine(book3.GetActualPrice());

            ReadingRooms room = new ReadingRooms();
            library.ReserveReadingRooms(room, new DateTime(2019, 05, 27));
            Console.WriteLine(library.ReservedRooms[0]);
            Console.WriteLine(room.Id);

            ReadingRooms room2 = new ReadingRooms();
            library.ReserveReadingRooms(room2, new DateTime(2019, 05, 27));
            Console.WriteLine(library.ReservedRooms[1]);
            Console.WriteLine(room2.Id);

            #endregion

            #region Second Task

            Queue q = new Queue(3);
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            //q.Enqueue("D");
            q.ShowQueue();

            #endregion


        }
    }
}
