using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class ReverseKItems
    {
        public void ReverseItems(Node head, int k)
        {
            Node node1 = head;

            for (int i = 0; i < k; i++)
                node1 = node1.GetNext();

            Node current = head;
            Node prev = null;

            while (current != node1)
            {
                Node next = current.GetNext();
                current.setNext(prev);
                prev = current;
                current = next;
            }

            prev.setNext(node1.GetNext());
        }

        private Node ReverseList(Node head)
        {
            if (head == null)
                return null;

            Node current = head;
            Node prev = null;

            while(current != null)
            {
                Node next = current.GetNext();
                current.setNext(prev);
                prev = current;
                current = next;
            }
            return prev;
        }

    }
}
