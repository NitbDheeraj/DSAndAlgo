using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class DLLDeletion
    {
        DLLNode head;

        public void DeleteDLLNode(int key)
        {
            DLLNode temp = head;
            DLLNode prev = null;

            if (temp != null && temp.GetData() == key)
            {
                // Changed head
                head = temp.GetNext();
                head.SetPrev(null);
                return;
            }

            while (temp != null && temp.GetData() != key)
            {
                prev = temp;
                temp = temp.GetNext();
            }

            if (temp == null)
                return;

            temp.GetNext().SetPrev(prev);
            prev.SetNext(temp.GetNext());
        }

    }
}
