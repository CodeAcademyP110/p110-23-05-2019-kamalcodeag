using System;
using System.Collections.Generic;

namespace HomeWork
{
    public class Queue
    {
        public int QueueLength { get; private set; }
        private Queue<string> customers = new Queue<string>();
        public Queue(int n)
        {
            QueueLength = n;
        }

        public void Enqueue(string c)
        {
            if (customers.Count < QueueLength)
                customers.Enqueue(c);
            else
                throw new ArgumentException("Sorry, the queue is limited");
            
        }
        public void Dequeue()
        {
            customers.Dequeue();
        }
        public void ShowQueue()
        {
            foreach(string c in customers)
            {
                Console.WriteLine(c);
            }
        }
    }
}
