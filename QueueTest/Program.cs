using Anupom_Roy_Lab05_Ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anupom_Roy_Lab05_Ex31;

namespace QueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueInheritance queue = new QueueInheritance();

            // create objects to store in the queue
           
            //Double anDouble = 34567;
            string aString = "friends";

            // use method Enqueue to add items to queue
            queue.Enqueue("hello");
            queue.Display();
            queue.Enqueue(aString);
            queue.Display();
            queue.Enqueue("how");
            queue.Display();
            queue.Enqueue("are you");
            queue.Display();

        }
    }
}
