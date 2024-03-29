﻿using System;
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

            return CheckForSimilarity(binaryTree1.Left, binaryTree2.Left)
                && CheckForSimilarity(binaryTree1.Right, binaryTree2.Right);

            //  Time Complexity: O(n). Space Complexity: O(n), for recursive stack.

        }
    }

    //  Write Code to Determine if Two Trees are Identical
    public class IdenticalBinaryTrees
    {

        /*  Two trees are identical when they have same data and arrangement of data is also same.
            To identify if two trees are identical, we need to traverse both trees simultaneously, 
            and while traversing we need to compare data and children of the trees.
        */
        public bool IdenticalTrees(BinaryTreeNode<int> binaryTree1, BinaryTreeNode<int> binaryTree2)
        {
            if (binaryTree1 == null && binaryTree2 == null)
                return true;
            else if (binaryTree1 == null || binaryTree2 == null)/* one empty, one not -> false */
                return false;

            return (binaryTree1.Data == binaryTree2.Data) &&
               IdenticalTrees(binaryTree1.Left, binaryTree2.Left) &&
               IdenticalTrees(binaryTree1.Right, binaryTree2.Right);
            //  Time Complexity: O(n). Space Complexity: O(n), for recursive stack.
        }
    }
}
