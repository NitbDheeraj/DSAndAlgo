using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class CheckIfLengthIsOdd
    {
        public bool CheckIfOdd(Node head)
        {
            while(head != null && head.GetNext() != null)
            {
                head = head.GetNext().GetNext();
                if (head == null)
                    return false;
            }
            return true;
        }

    }
}
