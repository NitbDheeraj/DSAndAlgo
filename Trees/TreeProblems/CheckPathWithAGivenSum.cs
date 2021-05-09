using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    /*Given a binary tree and a number, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals the given number. 
     * Return false if no such path can be found. 
     */
    public class CheckPathWithAGivenSum
    {
        public bool HasPathSum(BinaryTreeNode<int> binaryTree, int sum)
        {
            if (binaryTree == null)
                return false;
            if (binaryTree.Left == null && binaryTree.Right == null && binaryTree.Data == sum)
                return true;
            else
                return HasPathSum(binaryTree.Left, sum - binaryTree.Data) || HasPathSum(binaryTree.Right, sum - binaryTree.Data);
        }

    }
}
