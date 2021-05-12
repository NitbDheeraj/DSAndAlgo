using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    //Programatically there is no difference between BST node and binary tree node
    public class BSTNode<T>
    {
        public BSTNode(T data)
        {
            Data = data;
        }

        public T Data;
        public BSTNode<T> Left;
        public BSTNode<T> Right;

        public T GetData()
        {
            return Data;
        }

        public void SetData(T data)
        {
            this.Data = data;
        }

        public void SetLeft(BSTNode<T> left)
        {
            this.Left = left;
        }

        public void SetRight(BSTNode<T> right)
        {
            this.Right = right;
        }

        public BSTNode<T> GetLeft()
        {
            return this.Left;
        }

        public BSTNode<T> GetRight()
        {
            return this.Right;
        }

    }
}
