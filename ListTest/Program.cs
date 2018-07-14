using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List(); // create List container

            // create data to store in List
            bool aBoolean = true;
            char aCharacter = 'A';
            Double anDouble = 34567;
            string aString = "hello";

            // use List insert methods       
            list.InsertAtFront(anDouble);
            list.Display();
            Console.WriteLine($"Number of Elements= {list.Count()}");
            list.InsertAtFront(aCharacter);
            list.Display();
            list.InsertAtBack(22.255);
            list.Display();
            list.InsertAtBack(1111111);
            list.Display();
            list.Search(1111111);
            Console.WriteLine("Number of Elements " + list.Count());

            // remove data from list and display after each removal
            try
            {
                object removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromFront();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();

                removedObject = list.RemoveFromBack();
                Console.WriteLine($"{removedObject} removed");
                list.Display();
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }

        }
    }
}
