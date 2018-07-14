using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    // class to represent one node in a list

   public  class ListNode
    {
        // automatic read-only property Data
        public Double Data { get; private set; }

        // automatic property Next
        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(Double dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(Double dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
