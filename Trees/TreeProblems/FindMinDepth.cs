using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    // Give an algorithm for finding the minimum depth of the binary tree.
    public class FindMinDepth
    {

        //level order traversal and return the depth on first leaf node
        public int minDepthIteratively(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return 0;
            int count = 1;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);
            while(q.Count() > 0)
            {
                BinaryTreeNode<int> curr = q.Dequeue();

                if (curr.Left == null && curr.Right == null)
                    return count;

                if (curr.Left != null)
                    q.Enqueue(curr.Left);

                if (curr.Right != null)
                    q.Enqueue(curr.Right);

                count++;
            }


            return count;
        }


        //Root of the Binary Tree
        public Node root;
        public virtual int minimumDepth()
        {
            return minimumDepth(root);
        }


        /* Function to calculate the minimum depth of the tree */
        public virtual int minimumDepth(Node root)
        {
            // Corner case. Should never be hit unless the code is
            // called on root = NULL
            if (root == null)
            {
                return 0;
            }

            // Base case : Leaf Node. This accounts for height = 1.
            if (root.left == null && root.right == null)
            {
                return 1;
            }

            // If left subtree is NULL, recur for right subtree
            if (root.left == null)
            {
                return minimumDepth(root.right) + 1;
            }

            // If right subtree is NULL, recur for left subtree
            if (root.right == null)
            {
                return minimumDepth(root.left) + 1;
            }

            return Math.Min(minimumDepth(root.left), minimumDepth(root.right)) + 1;
        }

    }

    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
}
