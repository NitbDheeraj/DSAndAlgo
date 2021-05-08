using System.Collections.Generic;
using System.Linq;

namespace Trees.TreeProblems
{
    /// <summary>
    /// Give an algorithm for finding maximum element in binary tree.
    /// </summary>
    public class FindMaxElement<T>
    {
        /*  One simple way of solving this problem is: find the maximum element in left subtree,
            find the maximum element in right sub tree, compare them with root data and select the one which
            is giving the maximum value. This approach can be easily implemented with recursion */
        public int FindMaxRecursively(BinaryTreeNode<int> binaryTree)
        {
            var maxValue = int.MinValue;

            if (binaryTree == null)
                return maxValue;

            var leftMax = FindMaxRecursively(binaryTree.Left);
            var rightMax = FindMaxRecursively(binaryTree.Right);

            if (leftMax < rightMax)
                maxValue = rightMax;
            else
                maxValue = leftMax;

            if (binaryTree.Data > maxValue)
                maxValue = binaryTree.Data;

            return maxValue;
        }

        /*  Using level order traversal: just observe the element’s data while deleting */
        public int FindMaxIteratively(BinaryTreeNode<int> binaryTree)
        {
            var maxValue = int.MinValue;
            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();

            q.Enqueue(binaryTree);

            while(q.Count() > 0)
            {
                var currVal = q.Dequeue();

                if (currVal.Data > maxValue)
                    maxValue = currVal.Data;

                if (currVal.Left != null)
                    q.Enqueue(currVal.Left);

                if (currVal.Right != null)
                    q.Enqueue(currVal.Right);
            }

            return maxValue;
        }

    }
}
