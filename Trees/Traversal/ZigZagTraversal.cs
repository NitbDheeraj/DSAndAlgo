using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Traversal
{
    //Give an algorithm to traverse a binary tree in Zigzag order.For example, the output for the tree below should be: 1 3 2 4 5 6 7
    //              1
    //             / \
    //            2   3
    //           / \ / \
    //          4  5 6  7 
    public class ZigZagTraversal
    {
        public void PrintZigZagTraversal(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return;

            // declare two stacks
            Stack<BinaryTreeNode<int>> currentLevel = new Stack<BinaryTreeNode<int>>();
            Stack<BinaryTreeNode<int>> nextLevel = new Stack<BinaryTreeNode<int>>();
 
            currentLevel.Push(binaryTree);
            bool leftToRight = true;

            while (currentLevel.Count() > 0)
            {
                BinaryTreeNode<int> front = currentLevel.Pop();

                Console.Write(front.Data);

                if(leftToRight)
                {
                    if (front.Left != null)
                        nextLevel.Push(front.Left);
                    if (front.Right != null)
                        nextLevel.Push(front.Right);
                }
                else
                {
                    if (front.Right != null)
                        nextLevel.Push(front.Right);
                    if (front.Left != null)
                        nextLevel.Push(front.Left);
                }

                if(currentLevel.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Stack<BinaryTreeNode<int>> temp = currentLevel;
                    currentLevel = nextLevel;
                    nextLevel = temp;
                }

            }
        }

        public void PrintZigZagTraversal1(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return;

            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);
            bool leftToRight = true;

            while (q.Count() > 0)
            {
                // calculate the total number of nodes at the current level
                int size = q.Count();

                List<int> currentLevelData = new List<int>();
                while (size-- > 0)
                {
                    BinaryTreeNode<int> front = q.Dequeue();
                    currentLevelData.Add(front.Data);
                    if (front.Left != null)
                    {
                        q.Enqueue(front.Left);
                    }

                    if (front.Right != null)
                    {
                        q.Enqueue(front.Right);
                    }
                }

                if (leftToRight) 
                    currentLevelData.ForEach(x => Console.Write(x));
                else
                {
                    for (int i = currentLevelData.Count() - 1; i >= 0; i--)
                        Console.Write(currentLevelData[i]);
                }
                leftToRight = !leftToRight;
            }
        }

    }
}
