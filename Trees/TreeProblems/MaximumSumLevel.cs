using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Give an algorithm for finding maximum level sum in the binary tree.
    /*Input :         4
                    /   \
                   2    -5
                  / \    /\
                -1   3 -2  6
                Output: 6
                Explanation :
                Sum of all nodes of 0'th level is 4
                Sum of all nodes of 1'th level is -3
                Sum of all nodes of 0'th level is 6
                Hence maximum sum is 6

                Input :          1
                               /   \
                             2      3
                           /  \      \
                          4    5      8
                                    /   \
                                   6     7  
                Output :  17
     */


    public class MaximumSumLevel
    {
        /*  This problem is a variation of maximum width problem. The idea is to do level order traversal of tree.
         *  While doing traversal, process nodes of different level separately. 
         *  For every level being processed, compute sum of nodes in the level and keep track of maximum sum.
         */

        public int MaxSumLevel(BinaryTreeNode<int> binaryTree)
        {
            int maxSumLevel = 0;

            if (binaryTree == null)
                return maxSumLevel;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);
            int currentLevelSum = 0;
            while (q.Count() > 0)
            {
                int count = q.Count;
                 
                while (count-- > 0)
                {
                    BinaryTreeNode<int> front = q.Dequeue();
                    currentLevelSum += front.Data;
                    if (front.Left != null)
                    {
                        q.Enqueue(front.Left);
                    }

                    if (front.Right != null)
                    {
                        q.Enqueue(front.Right);
                    }
                }
                // Update the maximum node sum value
                maxSumLevel = Math.Max(maxSumLevel, currentLevelSum);
                currentLevelSum = 0;

            }
            return maxSumLevel;
        }
    }
}
