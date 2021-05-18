using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class MergingPointInLists
    {
        public Node FindMergingPoint(Node Head1, Node Head2)
        {
            int L1 = FindLengthOfList(Head1);
            int L2 = FindLengthOfList(Head2);
            int d = 0;

            if (L1 > L2)
            {
                d = L1 - L2;
                return MergingPoint(Head1, Head2, d);
            }
            else
            {
                d = L2 - L1;
                return MergingPoint(Head2, Head1, d);
            }
        }

        private Node MergingPoint(Node head1, Node head2, int d)
        {
            int i;
            Node current1 = head1;
            Node current2 = head2;
            for (i = 0; i < d; i++)
            {
                current1 = current1.GetNext();
            }

            while (current1 != null && current2 != null)
            {
                if (current1.getData() == current2.getData())
                    return current1;

                current1 = current1.GetNext();
                current2 = current2.GetNext();
            }
            return null;
        }

        public int FindLengthOfList(Node head)
        {
            int length = 0;
            Node current = head;

            while (current != null)
            {
                length++;
                current = current.GetNext();
            }
            return length;
        }

    }
}
