using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    //Print nth node from the end in a linked list

    /*  Solution:
        Use two pointers pNthNode and pTemp. Initially, both point
        to head node of the list. pNthNode starts moving only after pTemp has made n moves.
        From there both move forward until pTemp reaches the end of the list. As a result pNthNode
        points to nth node from the end of the linked list.
    */
    public class NthNodeFromEnd
    {
        public Node GetNthNodeFromEnd(Node head, int n)
        {
            Node pTemp = head;
            Node pNthNode = null;

            for (int i = 1; i < n; i++)
            {
                if (pTemp.GetNext() != null)
                    pTemp = pTemp.GetNext();
            }
            pNthNode = head;
            while (pTemp != null)
            {
                pTemp = pTemp.GetNext();
                pNthNode = pNthNode.GetNext();
            }

            return pNthNode;
        }
        

    }
}
