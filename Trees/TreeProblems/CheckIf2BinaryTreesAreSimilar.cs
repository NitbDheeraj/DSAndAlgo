using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Given two binary trees, return true if they are structurally identical.
    public class CheckIf2BinaryTreesAreSimilar
    {
        /*  • If both trees are NULL then return true.
            • If both trees are not NULL, then recursively check left and right subtree structures.
        */
        public bool CheckForSimilarity(BinaryTreeNode<int> binaryTree1, BinaryTreeNode<int> binaryTree2)
        {
            if (binaryTree1 == null && binaryTree2 == null)
                return true;
            else if (binaryTree1 == null || binaryTree2 == null) //The code will enter in this condition only if one of them is not null
                return false;

            return CheckForSimilarity(binaryTree1.Left, binaryTree2.Right) 
                && CheckForSimilarity(binaryTree1.Right, binaryTree2.Left);

            //  Time Complexity: O(n). Space Complexity: O(n), for recursive stack.

        }
    }
}
