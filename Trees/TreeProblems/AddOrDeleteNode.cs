using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    public class AddOrDeleteNode
    {
        /*  Since the given tree is a binary tree, we can insert the element wherever we want. To
            insert an element, we can use the level order traversal and insert the element wherever we find
            the node whose left or right child is NULL
        */
        public BinaryTreeNode<int> AddNodeIteratively(BinaryTreeNode<int> binaryTree, int data)
        {
            if (binaryTree == null)
                return binaryTree;
            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();

            q.Enqueue(binaryTree);

            while(q.Count() > 0)
            {
                var curr = q.Dequeue();

                if(curr.Left != null)
                    q.Enqueue(curr.Left);
                else
                {
                    BinaryTreeNode<int> newNode = new BinaryTreeNode<int>(data);
                    curr.Left = newNode;
                    return binaryTree;
                }

                if(curr.Right != null)
                    q.Enqueue(curr.Right);
                else
                {
                    BinaryTreeNode<int> newNode = new BinaryTreeNode<int>(data);
                    curr.Right = newNode;
                    return binaryTree;
                }
            }
            return binaryTree;

        }



    }
}
