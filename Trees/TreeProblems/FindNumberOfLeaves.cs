using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Give an algorithm for finding the number of leaves in the binary tree without using recursion.
    public class FindNumberOfLeaves
    {
        //The set of nodes whose both left and right children are NULL are called leaf nodes
        public int FindNumberOfLeave(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return 0;
            int count = 0;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);
            while (q.Count() > 0)
            {
                BinaryTreeNode<int> curr = q.Dequeue();

                if (curr.Left == null && curr.Right == null)
                    count ++;

                if (curr.Left != null)
                    q.Enqueue(curr.Left);

                if (curr.Right != null)
                    q.Enqueue(curr.Right);

            }


            return count;
        }

    }

    //Give an algorithm for finding the number of full nodes in the binary tree without using recursion.
    //The set of all nodes with both left and right children are called full nodes
    public class FindNumberOfFullNodes
    {
        public int FindNumberOfFullNode(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return 0;
            int count = 0;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);
            while (q.Count() > 0)
            {
                BinaryTreeNode<int> curr = q.Dequeue();

                if (curr.Left != null && curr.Right != null)
                    count++;

                if (curr.Left != null)
                    q.Enqueue(curr.Left);

                if (curr.Right != null)
                    q.Enqueue(curr.Right);

            }


            return count;
        }
    }
}
