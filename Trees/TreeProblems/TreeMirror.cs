using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    public class TreeMirror
    {

        /*  Give an algorithm for converting a tree to its mirror. Mirror of a tree is another
            tree with left and right children of all non-leaf nodes interchanged. The trees below are
            mirrors to each other.
        */

        public BinaryTreeNode<int> ConvertTreeToItsMirror(BinaryTreeNode<int> root)
        {
            if (root == null)
                return root;

            var left = ConvertTreeToItsMirror(root.Left);
            var right = ConvertTreeToItsMirror(root.Right);

            root.Left = right;
            root.Right = left;

            return root;
        }


        //  Given two trees, give an algorithm for checking whether they are mirrors of
        //  each other.

        public bool CheckIfBinaryTreeAreMirror(BinaryTreeNode<int> root1, BinaryTreeNode<int> root2)
        {
            if (root1 == null && root2 == null)
                return true;
            else if (root1 == null || root2 == null)
                return false;

            if (root1.Data != root2.Data)
                return false;

            return CheckIfBinaryTreeAreMirror(root1.Left, root2.Right) && CheckIfBinaryTreeAreMirror(root1.Right, root2.Left);
        }

    }
}
