using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.BasicOperations
{
    public class Insertion
    {

        public Node head; // head of list
        /* Inserts a new Node at front of the list. */
        public void InsertAtBegning(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.setNext(head);

            /* 4. Move the head to point to new Node */
            head = new_node;
        }
        /* Inserts a new node after the given prev_node. */
        public void insertAfter(Node prev_node, int new_data)
        {
            /* 1. Check if the given Node is null */
            if (prev_node == null)
            {
                Console.WriteLine("The given previous" +
                                  " node cannot be null");
                return;
            }

            /* 2 & 3: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 4. Make next of new Node as
                  next of prev_node */
            new_node.setNext(prev_node.GetNext());

            /* 5. make next of prev_node as new_node */
            prev_node.setNext(new_node);
        }

        /* Appends a new node at the end. This method is defined inside LinkedList class shown above */
        public void InsertAtEnd(int new_data)
        {
            /* 1. Allocate the Node &
            2. Put in the data
            3. Set next as null */
            Node new_node = new Node(new_data);

            /* 4. If the Linked List is empty, then make the new node as head */
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            /* 4. This new node is going to be the last node, so make next of it as null */
            new_node.setNext(null);

            /* 5. Else traverse till the last node */
            Node last = head;
            while (last.GetNext() != null)
                last = last.GetNext();

            /* 6. Change the next of last node */
            last.setNext(new_node);
            return;
        }

    }
}
