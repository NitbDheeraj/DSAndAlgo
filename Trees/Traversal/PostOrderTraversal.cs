using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Traversal
{
    /// <summary>
    /// • Traverse the left subtree in Postorder.
    /// • Traverse the right subtree in Postorder.
    /// • Visit the root.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PostOrderTraversal<T>
    {
        public void PostOrder(BinaryTreeNode<T> root)
        {
            //Inorder Traversal in Recursive manner
            //Time Complexity: O(n). Space Complexity: O(n)
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write(root.Data);
            }
        }

        /*  1. Push root to first stack.
            2. Loop while first stack is not empty
                2.1 Pop a node from first stack and push it to second stack
                2.2 Push left and right children of the popped node to first stack
            3. Print contents of second stack
         */
        public void IterativePostOrder(BinaryTreeNode<T> root)
        {
            if (root == null)
                return;

            Stack<BinaryTreeNode<T>> s1 = new Stack<BinaryTreeNode<T>>();
            Stack<BinaryTreeNode<T>> s2 = new Stack<BinaryTreeNode<T>>();

            // Push root to first stack
            s1.Push(root);

            // Run while first stack is not empty
            while(s1.Count() > 0)
            {
                // Pop an item from s1 and Push it to s2
                BinaryTreeNode<T> temp = s1.Pop();
                s2.Push(temp);

                // Push left and right children of
                // removed item to s1
                if (temp.Left != null)
                    s1.Push(temp.Left);

                if (temp.Right != null)
                    s1.Push(temp.Right);

            }

            // Print all elements of second stack
            while(s2.Count > 0)
            {
                BinaryTreeNode<T> temp1 = s2.Pop();
                Console.Write(temp1.Data);
            }
        }


    }
}
