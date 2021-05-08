using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    /// <summary>
    /// Give an algorithm for searching an element in binary tree.
    /// </summary>
    public class SearchAnElement
    {
        /*  Given a binary tree, return true if a node with data is found in the tree. Recurse down
            the tree, choose the left or right branch by comparing data with each nodes data.   */
        public bool SearchElementRecursively(BinaryTreeNode<int> binaryTree, int data)
        {
            if (binaryTree == null)
                return false;

            if (binaryTree.Data == data)
                return true;

            return SearchElementRecursively(binaryTree.Left, data) || SearchElementRecursively(binaryTree.Right, data);
        }


        /*  We can use level order traversal for solving this problem. The only change required in
            level order traversal is, instead of printing the data, we just need to check whether the root data is
            equal to the element we want to search  */
        public bool SearchElementIteratively(BinaryTreeNode<int> binaryTree, int data)
        {
            bool returnValue = false;
            Queue<BinaryTreeNode<int>> q = new Queue<BinaryTreeNode<int>>();
            q.Enqueue(binaryTree);

            while (q.Count() > 0)
            {
                var curr = q.Dequeue();

                if (curr.Data == data)
                    return true;

                if (curr.Left != null)
                    q.Enqueue(curr.Left);

                if (curr.Right != null)
                    q.Enqueue(curr.Right);

            }


            return returnValue;
        }
    }
}
