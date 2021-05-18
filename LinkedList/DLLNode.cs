using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DLLNode
    {
        private int _data;
        private DLLNode _prev;
        private DLLNode _next;

        public DLLNode(int data)
        {
            this._data = data;
            _prev = null;
            _next = null;
        }
        public DLLNode(int data, DLLNode prev, DLLNode next)
        {
            this._data = data;
            _prev = prev;
            _next = next;
        }
        public void SetData(int data)
        {
            this._data = data;
        }
        public int GetData()
        {
            return _data;
        }
        public void SetNext(DLLNode next)
        {
            this._next = next;
        }
        public DLLNode GetNext()
        {
            return this._next;
        }

        public DLLNode GetPrev()
        {
            return this._prev;
        }

        public void SetPrev(DLLNode prev)
        {
            this._prev = prev;
        }
    }
}
