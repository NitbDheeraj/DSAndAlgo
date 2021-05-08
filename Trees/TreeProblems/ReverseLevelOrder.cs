using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //  Give an algorithm for printing the level order data in reverse order.
    //  for the following binary tree
    //              1
    //             / \
    //            2   3
    //           / \ / \
    //          4  5 6  7
    //  it should print the order 4567231
    public class ReverseLevelOrder
    {
        public void LevelOrderReversal(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return;

            Stack<BinaryTreeNode<int>> s = new Stack<BinaryTreeNode<int>>();
            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();

            q.Enqueue(binaryTree);

            while(q.Count() > 0)
            {
                var curr = q.Dequeue();

                // NOTE: RIGHT CHILD IS ENQUEUED BEFORE LEFT
                if (curr.Right != null)
                    q.Enqueue(curr.Right);

                if (curr.Left != null)
                    q.Enqueue(curr.Left);

                s.Push(curr);
            }

            while(s.Count > 0)
            {
                var curr = s.Pop();
                Console.Write(curr.Data);
            }

        }
    }
}
