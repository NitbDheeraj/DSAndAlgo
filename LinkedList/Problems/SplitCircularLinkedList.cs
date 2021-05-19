using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class SplitCircularLinkedList
    {
        public void SplitList(Node head)
        {
            Node slow_ptr = head;
            Node fast_ptr = head;

            if (head == null)
                return;
            /* If there are odd nodes in the circular list then fast_ptr->next becomes head and for even nodes fast_ptr->next->next becomes head */
            while (fast_ptr.GetNext() != head && fast_ptr.GetNext().GetNext() != head)
            {
                fast_ptr = fast_ptr.GetNext().GetNext();
                slow_ptr = slow_ptr.GetNext();
            }
            /* If there are even elements in list then move fast_ptr */
            if (fast_ptr.GetNext().GetNext() == head)
                fast_ptr = fast_ptr.GetNext();
            /*Set the head pointer of first half */
            Node head1 = head;
            Node head2 = slow_ptr.GetNext();

            //First cycle
            slow_ptr.setNext(head1);
            head2.setNext(fast_ptr);
        }

    }
}
