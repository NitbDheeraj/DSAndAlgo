using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class FindAnElementInBST
    {
        /*  Find operation is straightforward in a BST. Start with the root and keep moving left or right using
            the BST property. If the data we are searching is same as nodes data then we return current node.
            If the data we are searching is less than nodes data then search left subtree of current node;
            otherwise search right subtree of current node. If the data is not present, we end up in a null link.
        */
        public BSTNode<int> FindANode(BSTNode<int> binaryTree, BSTNode<int> node)
        {
            if (binaryTree == null || node == null)
                return null;

            if (node.Data == binaryTree.Data)
                return binaryTree;

            if (node.Data < binaryTree.Data)
                return FindANode(binaryTree.Left, node);

            if (node.Data > binaryTree.Data)
                return FindANode(binaryTree.Right, node);

            return binaryTree;
        }

        public BSTNode<int> FindANodeIteratively(BSTNode<int> binaryTree, BSTNode<int> node)
        {
            if (binaryTree == null)
                return null;

            while (binaryTree != null)
            {
                if (binaryTree.Data == node.Data)
                    return binaryTree;
                else if (node.Data < binaryTree.Data)
                    binaryTree = binaryTree.Left;
                else if (node.Data > binaryTree.Data)
                    binaryTree = binaryTree.Right;
            }
            return null;
        }

        public BSTNode<int> FindMinimum(BSTNode<int> binaryTree)
        {
            if (binaryTree == null)
                return null;

            if (binaryTree.Left == null)
                return binaryTree;
            else
                return FindMinimum(binaryTree.Left);

        }

        public BSTNode<int> FindMinimumIteratively(BSTNode<int> binaryTree)
        {
            if (binaryTree == null)
                return null;

            while (binaryTree.Left != null)
            {
                binaryTree = binaryTree.Left;
            }

            return binaryTree;
        }
    
        public BSTNode<int> FindMaximum(BSTNode<int> binaryTree)
        {
            if (binaryTree == null)
                return null;

            if (binaryTree.Right == null)
                return binaryTree;
            else
                return FindMaximum(binaryTree.Right);

        }

        public BSTNode<int> FindMaximumIteratively(BSTNode<int> binaryTree)
        {
            if (binaryTree == null)
                return null;

            while(binaryTree != null)
            {
                if (binaryTree.Right == null)
                    return binaryTree;

                binaryTree = binaryTree.Right;
            }
            return binaryTree;
        }

    }
}
