﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{    public class Node
    {
        private int _data;
        private Node _next;

        public Node(int data) => this._data = data;
        public void SetData(int data) => this._data = data;
        public int getData() => this._data;
        public void setNext(Node next) => this._next = next;
        public Node GetNext() => this._next;
    }
}
