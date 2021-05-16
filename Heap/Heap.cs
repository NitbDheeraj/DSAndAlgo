using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Heap
    {
        public int[] _arr;
        public int _count;
        public int _capacity;
        public int _type;

        public Heap(int capacity, int heap_type)
        {
            this._capacity = capacity;
            this._type = heap_type;
            this._count = 0;
            this._arr = new int[capacity];

        }

        //For a node at ith location, its parent is at (i - 1)/2 location
        public int Parent(int i)
        {
            if (i <= 0 || i >= this._count)
                return -1;
            return (i - 1) / 2;
        }

        public int LeftChild(int i)
        {
            int left = 2 * i + 1;
            if (left >= this._count)
                return -1;
            return left;
        }

        public int RightChild(int i)
        {
            int right = 2 * i + 2;
            if (right >= this._count)
                return -1;
            return right;
        }


    }
}
