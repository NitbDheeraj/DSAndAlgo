using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class CheckIfPalindrome
    {
        public bool CheckPalindrome(Node head)
        {
            Node mid = GetMid(head);
            Node node1 = head;
            while(node1 != mid)
                node1 = node1.GetNext();

            Node node2 = ReverseList(mid.GetNext());

            while(node1 != null)
            {
                if (node1 != node2)
                    return false;
            }
            return true;

        }

        private Node GetMid(Node head)
        {
            Node rabbit = head;
            Node Tortoise = head;

            while(rabbit.GetNext()!= null )
            {
                rabbit = rabbit.GetNext().GetNext();
                Tortoise = Tortoise.GetNext();
            }
            return Tortoise;
        }

        private Node ReverseList(Node head)
        {
            if (head == null)
                return null;

            Node current = head;
            Node prev = null;
            while(current != null)
            {
                var next = current.GetNext();
                current.setNext(prev);
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
