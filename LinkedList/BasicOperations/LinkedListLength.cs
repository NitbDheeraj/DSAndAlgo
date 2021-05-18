using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class LinkedListLength
    {
        public int ListLength(Node startNode)
        {
            int length = 0;
            Node currentNode = startNode;
            while(currentNode != null)
            {
                length++;
                currentNode = currentNode.GetNext();
            }

            return length;
        }

    }
}
