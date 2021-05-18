using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Implementation
{
    /*  EnQueue operation is implemented
        by inserting an element at the end of the list. DeQueue operation is implemented by deleting an
        element from the beginning of the list
     */
    public class LinkedListImplementation
    {
        private int _length;
        private LinkListNode _front, _rear;

        //Creates an empty queue
        public LinkedListImplementation()
        {
            _length = 0;
            _front = _rear = null;
        }

        //Returns true if queue is empty
        public Boolean IsEmpty()
        {
            return _length == 0;
        }

        //Returns the length of the queue
        public int Size()
        {
            return _length;
        }

        //Adds specific data to rear of queue
        public void Enqueue(int data)
        {
            LinkListNode node = new LinkListNode(data);
            if (IsEmpty())
                _front = node;
            else
                _rear.setNext(node);
            _rear = node;
            _length++;
        }

        //Removes the data from the front of the queue
        public int Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Empty Queue");
            int result = _front.getData();
            _front = _front.GetNext();
            _length--;
            if (IsEmpty())
                _rear = null;

            return result;
        }
        public int First()
        {
            if(IsEmpty())
                throw new Exception("Empty Queue");
            return _front.getData();
        }
    }

    public class LinkListNode
    {
        private int _data;
        private LinkListNode next;

        public LinkListNode(int data)
        {
            this._data = data;

        }
        public void SetData(int data)
        {
            this._data = data;
        }
        public int getData()
        {
            return _data;
        }
        public void setNext(LinkListNode next)
        {
            this.next = next;
        }
        public LinkListNode GetNext()
        {
            return this.next;
        }
    }
}
