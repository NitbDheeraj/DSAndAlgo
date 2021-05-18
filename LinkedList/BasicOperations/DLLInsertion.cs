using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class DLLInsertion
    {
        public DLLNode head; // head of list

        // Adding a node at the front of the list
        public void InsertAtBegning(int new_data)
        {

            /* 1. allocate node
            * 2. put in the data */
            DLLNode new_Node = new DLLNode(new_data);

            /* 3. Make next of new node as head and previous as NULL */
            new_Node.SetNext(head);
            new_Node.SetPrev(null);

            /* 4. change prev of head node to new node */
            if (head != null)
                head.SetPrev(new_Node);

            /* 5. move the head to point to the new node */
            head = new_Node;
        }

        /* Given a node as prev_node, insert a new node after the given node */
        public void InsertAfter(DLLNode prev_Node, int new_data)
        {

            /*1. check if the given prev_node is NULL */
            if (prev_Node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }

            /* 2. allocate node
            * 3. put in the data */
            DLLNode new_node = new DLLNode(new_data);

            /* 4. Make next of new node as next of prev_node */
            new_node.SetNext(prev_Node.GetNext());

            /* 5. Make the next of prev_node as new_node */
            prev_Node.SetNext(new_node);

            /* 6. Make prev_node as previous of new_node */
            new_node.SetPrev(prev_Node);

            /* 7. Change previous of new_node's next node */
            if (new_node.GetNext() != null)
                new_node.GetNext().SetPrev(new_node);
        }

        // Add a node at the end of the list
        public void InsertAtEnd(int new_data)
        {
            /* 1. allocate node
            * 2. put in the data */
            DLLNode new_node = new DLLNode(new_data);

            DLLNode last = head; /* used in step 5*/

            /* 3. This new node is going
                to be the last node, so
            * make next of it as NULL*/
            new_node.SetNext(null);

            /* 4. If the Linked List is empty,
            then make the new * node as head */
            if (head == null)
            {
                new_node.SetPrev(null);
                head = new_node;
                return;
            }

            /* 5. Else traverse till the last node */
            while (last.GetNext() != null)
                last = last.GetNext();

            /* 6. Change the next of last node */
            last.SetNext(new_node);

            /* 7. Make last node as previous of new node */
            new_node.SetPrev(last);
        }
    }
}
