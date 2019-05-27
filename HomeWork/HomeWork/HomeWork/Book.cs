using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Book
    {
        public string Name { get; private set; }
        public int SerialNumber { get; private set; }
        public string Genre { get; private set; }
        public string Author { get; private set; }
        public int Price { get; private set; }
        public bool HasDiscount { get; private set;}
        private int DiscountPercent;
        public int GetDiscountPercent()
        {
            return DiscountPercent;
        }
        private void SetDiscountPercent(int percent)
        {
            if (HasDiscount == true)
            {
                DiscountPercent = percent;
            }
            else
            {
                throw new ArgumentException("Sorry, there is no discount in this book yet");
            }
        }

        private int ActualPrice;
        public int GetActualPrice()
        {
            return ActualPrice;
        }
        private void SetActualPrice(int percent)
        {
            if (percent > 0 && percent < 100)
            {
                int result = Price - ((Price * percent) / 100);
                ActualPrice = result;
            }
            else
            {
                throw new ArgumentException("Please, input a valid discount percent");
            }
        }

        #region ERROR - STACKOVERFLOW

        //public int DiscountPercent
        //{
        //    get
        //    {
        //        return DiscountPercent;
        //    }
        //    private set
        //    {
        //        if (HasDiscount == true)
        //        {
        //            DiscountPercent = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("Sorry, there is no discount in this book yet");
        //        }
        //    }
        //}

        //public int ActualPrice
        //{
        //    get
        //    {
        //        return ActualPrice;
        //    }
        //    private set
        //    {
        //        if (DiscountPercent > 0 && DiscountPercent < 100)
        //        {
        //            ActualPrice = Price - ((Price * DiscountPercent) / 100);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please, input a valid discount percent");
        //            ActualPrice = Price;
        //        }
        //    }
        //}
        #endregion


        public static int Quantity { get; private set; } = 1; //0 >>> 1

        public Book(string name, int serial, string genre, string author, int price, bool discount)
        {
            Name = name;
            SerialNumber = serial;
            Genre = genre;
            Author = author;
            Price = price;
            HasDiscount = discount;
        }
        public Book(string name,int serial,string genre,string author,int price,bool discount,int percent) :this(name,serial,genre,author,price,discount)
        {
            SetDiscountPercent(percent);
            SetActualPrice(percent);
            //DiscountPercent = percent;
            Quantity++;
        }
        

    }
}
