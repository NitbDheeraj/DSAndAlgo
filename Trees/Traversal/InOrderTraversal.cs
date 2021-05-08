using System;
using System.Collections.Generic;
using System.Linq;

namespace Trees.Traversal
{
    /// <summary>
    /// • Traverse the left subtree in Inorder.
    /// • Visit the root.
    /// • Traverse the right subtree in Inorder.
    /// </summary>
    public class InOrderTraversal<T>
    {
        public void InOrder(BinaryTreeNode<T> root)
        {
            //Inorder Traversal in Recursive manner
            //Time Complexity: O(n). Space Complexity: O(n)
            if (root != null)
            {
                InOrder(root.Left);
                Console.Write(root.Data);
                InOrder(root.Right);
            }
        }

        /// <summary>
        /// The Non-recursive version of Inorder traversal is similar to Preorder. The only change is, instead
        /// of processing the node before going to left subtree, process it after popping(which is indicated
        /// after completion of left subtree processing).
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public void IterativeInOrder(BinaryTreeNode<T> root)
        {
            List<T> res = new List<T>();

            Stack<BinaryTreeNode<T>> s = new Stack<BinaryTreeNode<T>>();

            BinaryTreeNode<T> currentNode = root;
            Boolean done = false;

            while (!done)
            {
                //Traverse Left Tree
                if (currentNode != null)
                {
                    s.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (s.Count() == 0)
                        done = true;
                    else
                    {
                        currentNode = s.Pop();
                        res.Add(currentNode.Data);
                        currentNode = currentNode.Right;
                    }
                }

            }
            res.ForEach(x => Console.Write(x.ToString())) ;
        }
    }
}
