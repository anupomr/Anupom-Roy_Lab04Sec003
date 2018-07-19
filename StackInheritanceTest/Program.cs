using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anupom_Roy_Lab05_Ex2;
using LinkedListLibrary;

namespace StackInheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StackInheritance stack = new StackInheritance();
            Double anDouble = 34567;

            // use method Push to add items to stack
            stack.Push(12);
            stack.Display();
            stack.Push(25);
            stack.Display();
            stack.Push(anDouble);
            stack.Display();
            stack.Push(35.25);
            stack.Display();
            Console.WriteLine("Top one is "+stack.Peek());


            // remove items from stack
            try
            {
                while (true)
                {
                    Double removedObject = stack.Pop();
                    Console.WriteLine($"{removedObject} popped");
                    stack.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                // if exception occurs, write stack trace
                //Console.Error.WriteLine(emptyListException.StackTrace);
                Console.Error.WriteLine(emptyListException.Message);
            }
        }
    }
}
