using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class ReverseALinkedList
    {
        public Node Reverse(Node head)
        {
            Node current = head;

            Node prev = null;

            while(current != null)
            {
                Node next = current.GetNext();          //save next node
                current.setNext(prev);                  //Set current node to previous
                prev = current;                         //Update previous pointer to current pointer
                current = next;                         //Save next in current pointer
            }
            return prev;
        }

    }
}
