using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Give an algorithm for finding the sum of all elements in binary tree.
    public class FindSum
    {
        //  We can use level order traversal with simple change. Every time after deleting an
        //  element from queue, add the node’s data value to sum variable
        public int FindSumIteratively(BinaryTreeNode<int> root)
        {
            int sum = 0;
            if (root == null)
                return 0;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(root);

            while (q.Count() > 0)
            {
                BinaryTreeNode<int> temp = q.Dequeue();
                if (temp != null)
                {
                    sum += temp.Data;
                    if (temp.Left != null)
                        q.Enqueue(temp.Left);
                    if (temp.Right != null)
                        q.Enqueue(temp.Right);
                }

            }

            return sum;
        }

        //  Recursively, call left subtree sum, right subtree sum and add their values to current
        //  nodes data.
        public int FindSumRecursively(BinaryTreeNode<int> root)
        {
            if (root == null)
                return 0;
            return root.Data + FindSumRecursively(root.Left) + FindSumRecursively(root.Right);
        }

    }
}
