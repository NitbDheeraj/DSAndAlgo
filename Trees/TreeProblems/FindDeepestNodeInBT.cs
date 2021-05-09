using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    // Give an algorithm for finding the deepest node of the binary tree.
    public class FindDeepestNodeInBT
    {
        //The last node processed from queue in level order is the deepest node in binary tree.
        public BinaryTreeNode<int> FindDeepestNode(BinaryTreeNode<int> binaryTree)
        {
            BinaryTreeNode<int> temp = null;
            if (binaryTree == null)
                return null;
            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);

            while (q.Count() > 0)
            {
                temp = q.Dequeue();
                if (temp != null)
                {
                    if (temp.Left != null)
                        q.Enqueue(temp.Left);
                    if (temp.Right != null)
                        q.Enqueue(temp.Right);
                }

            }
            return temp;
        }
    }
}
