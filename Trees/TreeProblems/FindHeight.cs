using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    /// <summary>
    /// Give an algorithm for finding the height (or depth) of the binary tree.
    /// </summary>
    public class FindHeight
    {
        /*  Recursively calculate height of left and right subtrees of a node and assign height to the
            node as max of the heights of two children plus 1. This is similar to PreOrder tree traversal (and
            DFS of Graph algorithms).   */
        public int FindHeightOfTree(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return 0;
            int leftDepth = FindHeightOfTree(binaryTree.Left);
            int rightDepth = FindHeightOfTree(binaryTree.Right);
            return (leftDepth > rightDepth) ? leftDepth + 1 : rightDepth + 1;
        }

        //Using level order traversal. This is similar to BFS of Graph algorithms. End of level is identified with NULL.
        public int FindHeightIteratively(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return 0;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);
            int height = 0;
            BinaryTreeNode<int> front = null;

            while(q.Count() > 0)
            {
                // calculate the total number of nodes at the current level
                int size = q.Count();

                // process each node of the current level and enqueue their
                // non-empty left and right child
                while (size-- > 0)
                {
                    front = q.Dequeue();

                    if (front.Left != null)
                    {
                        q.Enqueue(front.Left);
                    }

                    if (front.Right != null)
                    {
                        q.Enqueue(front.Right);
                    }
                }
                // increment height by 1 for each level
                height++;
            }
            return height;
        }
    }
}
