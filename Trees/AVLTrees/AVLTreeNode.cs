using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.AVLTrees
{
    public class AVLTreeNode<T>
    {
        private T Data;
        private int _height;
        private AVLTreeNode<T> _left;
        private AVLTreeNode<T> _right;
        public AVLTreeNode(T data)
        {
            this.Data = data;
        }
        public T GetData()
        {
            return this.Data;
        }

        public AVLTreeNode<T> GetLeft()
        {
            return this._left;
        }
        public AVLTreeNode<T> GetRight()
        {
            return this._right;
        }

        public int GetHeight()
        {
            return this._height;
        }

        public void SetLeft(AVLTreeNode<T> node)
        {
            this._left = node;
        }
        public void SetRight(AVLTreeNode<T> node)
        {
            this._right = node;
        }

        public void SetHeight(int h)
        {
            this._height = h;
        }

    }
}
