using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class CycleInAList
    {
        public bool FindIfLoopExists(Node head)
        {
            Node fastPointer = head;
            Node pointer = head;

            while(fastPointer != null && fastPointer.GetNext() != null)
            {
                fastPointer = fastPointer.GetNext().GetNext();
                pointer = pointer.GetNext();
                if (fastPointer == pointer)
                    return true;
            }

            return false;
        }

        /*  After finding the loop in the
            linked list, we initialize the slowPtr to the head of the linked list. From that point onwards both
            slowPtr and fastPtr move only one node at a time. The point at which they meet is the start of the
            loop. Generally we use this method for removing the loops. Let x and y be travelers such that y is
            walking twice as fast as x (i.e. y = 2x). Further, let s be the place where x and y first started
            walking at the same time. Then when x and y meet again, the distance from s to the start of the
            loop is the exact same distance from the present meeting place of x and y to the start of the loop.
        */

        public Node FindBegningOfLoop(Node head)
        {
            Node fastPointer = head;
            Node pointer = head;
            bool loopExists = false;
            while (fastPointer != null && fastPointer.GetNext() != null)
            {
                fastPointer = fastPointer.GetNext().GetNext();
                pointer = pointer.GetNext();
                if (fastPointer == pointer)
                    loopExists = true;
            }
            if(loopExists)
            {
                pointer = head;
                while(pointer != fastPointer)
                {
                    pointer = pointer.GetNext();
                    fastPointer = fastPointer.GetNext();
                }
                return pointer;
            }
            return null;
        }

        public int FindLengthOfLoop(Node head)
        {
            Node fastPointer = head;
            Node pointer = head;
            bool loopExists = false;
            int length = 0;
            while (fastPointer != null && fastPointer.GetNext() != null)
            {
                fastPointer = fastPointer.GetNext().GetNext();
                pointer = pointer.GetNext();
                if (fastPointer == pointer)
                    loopExists = true;
            }

            if(loopExists)
            {
                do
                {
                    pointer = pointer.GetNext();
                    length++;
                }
                while (pointer != fastPointer);
            }

            return length;
        }

    }
}
