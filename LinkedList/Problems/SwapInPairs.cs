using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    /*
        Given a singly linked list, write a function to swap elements pairwise.


        Input : 1->2->3->4->5->6->NULL
        Output : 2->1->4->3->6->5->NULL
        Input : 1->2->3->4->5->NULL
        Output : 2->1->4->3->5->NULL
        Input : 1->NULL
        Output : 1->NULL


        For example, if the linked list is 1->2->3->4->5 then the function should change it to 2->1->4->3->5, and if the linked list is then the function should change it to.
    
    */
    public class SwapInPairs
    {
        public Node SwapPairs(Node head)
        {
            if (head == null)
                return null;

            Node current = head;

            while(current!= null && current.GetNext() != null)
            {
                var data = current.getData();
                current.SetData(current.GetNext().getData());
                current.GetNext().SetData(data);
                current = current.GetNext().GetNext();
            }

            return current;
        }

    }
}
