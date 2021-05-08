using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /// <summary>
    /// Class Representing Binary tree node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode(T value)
        {
            Data = value;
        }
        public T Data;
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;

        public T GetData()
        {
            return Data;
        }

        public void SetData(T data)
        {
            this.Data = data;
        }

        public void SetLeft(BinaryTreeNode<T> left)
        {
            this.Left = left;
        }

        public void SetRight(BinaryTreeNode<T> right)
        {
            this.Right = right;
        }

        public BinaryTreeNode<T> GetLeft()
        {
            return this.Left;
        }

        public BinaryTreeNode<T> GetRight()
        {
            return this.Right;
        }
    }


}
