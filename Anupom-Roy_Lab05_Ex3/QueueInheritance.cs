using LinkedListLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex3
{
    class QueueInheritance :List
    {
        // pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(Double dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public object Dequeue()
        {
            return RemoveFromFront();
        }
    }
}
