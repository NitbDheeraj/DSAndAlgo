using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    /// <summary>
    /// Give an algorithm for finding the size of binary tree
    /// </summary>
    public class FindSizeOfBinaryTree
    {
        // Calculate the size of left and right subtrees recursively, add 1 (current node) and return to its parent.
        public int FindSizeRecursively(BinaryTreeNode<int> binaryTree)
        {
            var size = 0;

            if (binaryTree == null)
                return 0;

            return FindSizeRecursively(binaryTree.Left) + FindSizeRecursively(binaryTree.Right) + 1;

        }

        //using level order traversal
        public int FindSizeIteratively(BinaryTreeNode<int> binaryTree)
        {
            var size = 0;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);

            while(q.Count() > 0)
            {
                var curr = q.Dequeue();

                if (curr.Left != null)
                    q.Enqueue(curr.Left);

                if (curr.Right != null)
                    q.Enqueue(curr.Right);

                size++;

            }

            return size;
        }

    }
}
