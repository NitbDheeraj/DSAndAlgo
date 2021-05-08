using System;
using System.Collections.Generic;
using System.Linq;

namespace Trees.Traversal
{
    /// <summary>
    /// Visit the root
    /// Traverse the left subtree in Preorder.
    /// Traverse the right subtree in Preorder
    /// </summary>
    public class PreOrderTraversal<T>
    {
        public void PreOrder(BinaryTreeNode<T> root)
        {
            //Preorder Traversal in Recursive manner
            //Time Complexity: O(n). Space Complexity: O(n)
            if (root != null)
            {
                Console.Write(root.Data);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }


        /// <summary>
        /// In the recursive version, a stack is required as we need to remember the current node so that after
        /// completing the left subtree we can go to the right subtree.To simulate the same, first we process
        /// the current node and before going to the left subtree, we store the current node on stack.After
        /// completing the left subtree processing, pop the element and go to its right subtree.Continue this
        /// process until stack is nonempty.
        /// Time Complexity: O(n).Space Complexity: O(n)
        /// </summary>
        /// <param name="root"></param>
        public void IterativePreOrder(BinaryTreeNode<T> root)
        {
            List<T> res = new List<T>();

            if (root == null)
                return;

            Stack<BinaryTreeNode<T>> s = new Stack<BinaryTreeNode<T>>();

            s.Push(root);

            while (s.Count() > 0)
            {
                BinaryTreeNode<T> tmp = s.Pop();
                res.Add(tmp.Data);

                //Pay Attention!!

                if (tmp.Right != null)
                    s.Push(tmp.Right);

                if (tmp.Left != null)
                    s.Push(tmp.Left);
            }
            res.ForEach(x => Console.Write(x.ToString()));
        }

    }
}
