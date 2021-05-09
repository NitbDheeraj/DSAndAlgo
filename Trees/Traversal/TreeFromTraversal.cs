using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.Traversal
{
    //Give an algorithm for constructing binary tree from given Inorder and Preorder traversals.
    /*  Let us consider the below traversals:
        Inorder sequence: D B E A F C 
        Preorder sequence: A B D E C F

        In a Preorder sequence, the leftmost element is the root of the tree. So we know ‘A’ is the root for given sequences. By searching ‘A’ in the Inorder sequence, we can find out all elements on the left side of ‘A’ is in the left subtree, and elements on right in the right subtree. So we know the below structure now. 

                 A
               /   \
             /       \
           D B E     F C
        We recursively follow the above steps and get the following tree.

                 A
               /   \
             /       \
            B         C
           / \        /
         /     \    /
        D       E  F

    */

    public class TreeFromTraversal
    {
        // Store indexes of all items so that we
        // we can quickly find later
        static Dictionary<char, int> mp = new Dictionary<char, int>();
        static int preIndex = 0;

        
        public BinaryTreeNode<char> BuildBinaryTree(char[] preOrder, char[] inOrder)
        {
            if (preOrder.Length == 0 && inOrder.Length == 0)
                return null;
            for (int i = 0; i < inOrder.Length ; i++)
            {
                mp.Add(inOrder[i], i);
            }

            return BuildBT(preOrder, inOrder, 0, preOrder.Length - 1);
        }

        /* Recursive function to construct binary of size
            len from Inorder traversal in[] and Preorder traversal
            pre[]. Initial values of inStrt and inEnd should be
            0 and len -1. The function doesn't do any error
            checking for cases where inorder and preorder
            do not form a tree 
        */
        private BinaryTreeNode<char> BuildBT(char[] preOrder, char[] inOrder, int inStrt, int inEnd)
        {
            if (inStrt > inEnd)
            {
                return null;
            }

            char data = preOrder[preIndex++];
            BinaryTreeNode<char> binaryTree = new BinaryTreeNode<char>(data);

            /* Else find the index of this node in Inorder traversal */
            int inIndex = mp[data];

            /*  Using index in Inorder traversal, construct left and
                right subtress */
            binaryTree.Left = BuildBT(preOrder, inOrder, inStrt, inIndex - 1);
            binaryTree.Right = BuildBT(preOrder, inOrder, inIndex + 1, inEnd);

            return binaryTree;
        }
    }


    /* Give an algorithm for constructing binary tree from given Inorder and Postorder traversals.
     */
    public class TreeFromInorderAndPostOrder<T>
    {
        // Store indexes of all items so that we
        // we can quickly find later
        static Dictionary<T, int> mp = new Dictionary<T, int>();
        static int postIndex = 0;

        public BinaryTreeNode<T> BuildBinaryTree(T[] postOrder, T[] inOrder)
        {
            if (postOrder.Length == 0 && inOrder.Length == 0)
                return null;
            for (int i = 0; i < inOrder.Length; i++)
            {
                mp.Add(inOrder[i], i);
            }
            postIndex = postOrder.Length - 1;
            return BuildBT(postOrder, inOrder, 0, postOrder.Length - 1);
        }

        private BinaryTreeNode<T> BuildBT(T[] postOrder, T[] inOrder, int inStrt, int inEnd)
        {
            if (inStrt > inEnd )
            {
                return null;
            }

            T data = postOrder[postIndex];
            BinaryTreeNode<T> binaryTree = new BinaryTreeNode<T>(data);
            (postIndex)--;
            /* Else find the index of this node in Inorder traversal */
            int inIndex = mp[data];

            /*  Using index in Inorder traversal, construct left and
                right subtress */
            
            binaryTree.Right = BuildBT(postOrder, inOrder, inIndex + 1, inEnd);
            binaryTree.Left = BuildBT(postOrder, inOrder, inStrt, inIndex - 1);

            return binaryTree;
        }

    }
}
