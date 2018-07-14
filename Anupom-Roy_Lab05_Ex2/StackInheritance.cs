using LinkedListLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex2
{
    public class StackInheritance : List
    {
        // pass name "stack" to List constructor
        public StackInheritance() : base("stack") { }

        // place dataValue at top of stack by inserting 
        // dataValue at front of linked list
        public void Push(Double dataValue)
        {
            InsertAtFront(dataValue);
        }
        // remove item from top of stack by removing
        // item at front of linked list
        public Double Pop()
        {
            return RemoveFromFront();
        }

        public Double Peek()
        {
            if (IsEmpty())
                return 0;

            //ListNode toKeep = lastNode.Next;
            ListNode current = firstNode;

           
            return current.Data;
        }

    }
}
