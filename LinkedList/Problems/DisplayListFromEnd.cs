using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class DisplayListFromEnd
    {
        //Traverse recursively till the end of the linked list. While coming back, start printing the elements.
        public void DisplayList(Node head)
        {
            if (head == null)
                return;
            DisplayList(head.GetNext());
            Console.Write(head.getData());
        }
    }
}
