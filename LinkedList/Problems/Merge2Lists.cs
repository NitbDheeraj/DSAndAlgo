using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    //Given two sorted Linked Lists, we need to merge them into the third list in sorted order.
    public class Merge2Lists
    {
        public Node Merge(Node head1, Node head2)
        {
            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;

            Node head = null;
            if(head1.getData() <= head2.getData())
            {
                head = head1;
                head.setNext(Merge(head1.GetNext(), head2));
            }
            else
            {
                head = head2;
                head.setNext(Merge(head1, head2.GetNext()));
            }
            return head;
        }

        public Node MergeIteratively(Node head1, Node head2)
        {
            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;
            Node head = null;

            while(head1 != null && head2 != null)
            {
                if (head1.getData() <= head2.getData())
                {
                    head.setNext(head1);
                    head1 = head1.GetNext();
                }
                else
                {
                    head.setNext(head2);
                    head2 = head1.GetNext();
                }
            }
            if(head1 == null)
            {
                while(head2 != null)
                    head.setNext(head2.GetNext());
            }
            if (head2 == null)
            {
                while (head1 != null)
                    head.setNext(head1.GetNext());
            }
            return head;
        }
    }
}
