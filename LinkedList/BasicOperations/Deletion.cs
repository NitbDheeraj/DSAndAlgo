using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class Deletion
    {
        // Head of list
        Node head;

        // Given a key, deletes the first occurrence of key in linked list
        public void deleteNode(int key)
        {
            // Store head node
            Node temp = head, prev = null;

            // If head node itself holds the key to be deleted
            if (temp != null && temp.getData() == key)
            {
                // Changed head
                head = temp.GetNext();
                return;
            }

            // Search for the key to be deleted, keep track of the previous node as we need to change temp.next
            while (temp != null && temp.getData() != key)
            {
                prev = temp;
                temp = temp.GetNext();
            }

            // If key was not present in linked list
            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.setNext(temp.GetNext());
        }

    }
}
