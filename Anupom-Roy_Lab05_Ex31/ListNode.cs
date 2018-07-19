using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex31
{
   public class ListNode
    {

        // automatic read-only property Data
        public string Data { get; private set; }

        // automatic property Next
        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(string dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(string dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
