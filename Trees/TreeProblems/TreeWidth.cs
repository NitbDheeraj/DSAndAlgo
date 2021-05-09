using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    /*Given a binary tree, write a function to get the maximum width of the given tree. Width of a tree is maximum of widths of all levels. 

        Let us consider the below example tree.  

                 1
                /  \
               2    3
             /  \     \
            4    5     8 
                      /  \
                     6    7

        For the above tree, 
        width of level 1 is 1, 
        width of level 2 is 2, 
        width of level 3 is 3 
        width of level 4 is 2. 
        So the maximum width of the tree is 3.
    */
    public class MaxTreeWidth
    {
        //  Using level order traversal
        /*  we store all the child nodes at the current level in the queue and then count the total number of nodes after the level order traversal for a particular level is completed.
         *  Since the queue now contains all the nodes of the next level, we can easily find out the total number of nodes in the next level by finding the size of queue. 
         *  We then follow the same procedure for the successive levels. We store and update the maximum number of nodes found at each level.
         */
        public int MaxWidthUsingLevelOrder(BinaryTreeNode<int> binaryTree)
        {
            int maxWidth = 0;

            if (binaryTree == null)
                return maxWidth;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);

            while ( q.Count() > 0)
            {
                // Get the size of queue when the level order
                // traversal for one level finishes
                int count = q.Count;

                // Update the maximum node count value
                maxWidth = Math.Max(maxWidth, count);

                while(count-- > 0)
                {
                    BinaryTreeNode<int> front = q.Dequeue();

                    if (front.Left != null)
                    {
                        q.Enqueue(front.Left);
                    }

                    if (front.Right != null)
                    {
                        q.Enqueue(front.Right);
                    }
                }

            }
            return maxWidth;
        }

    }
}
