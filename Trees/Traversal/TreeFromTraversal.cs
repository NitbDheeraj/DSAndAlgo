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

    public class TreeFromTraversal<T>
    {
        // Store indexes of all items so that we
        // we can quickly find later
        static Dictionary<T, int> mp = new Dictionary<T, int>();
        static int preIndex = 0;

        
        public BinaryTreeNode<T> BuildBinaryTree(T[] preOrder, T[] inOrder)
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
        private BinaryTreeNode<T> BuildBT(T[] preOrder, T[] inOrder, int inStrt, int inEnd)
        {
            if (inStrt > inEnd)
            {
                return null;
            }

            T data = preOrder[preIndex++];
            BinaryTreeNode<T> binaryTree = new BinaryTreeNode<T>(data);

            /* Else find the index of this node in Inorder traversal */
            int inIndex = mp[data];

            /*  Using index in Inorder traversal, construct left and
                right subtress */
            binaryTree.Left = BuildBT(preOrder, inOrder, inStrt, inIndex - 1);
            binaryTree.Right = BuildBT(preOrder, inOrder, inIndex + 1, inEnd);

            return binaryTree;
        }
    }


    /* Give an algorithm for constructing binary tree from given Inorder and Postorder traversals. */
    public class TreeFromInorderAndPostOrder<T>
    {
        Dictionary<T, int> dict = new Dictionary<T, int>();

        public BinaryTreeNode<T> BuildBinaryTree(T[] postOrder, T[] inOrder)
        {
            if (postOrder.Length == 0 && inOrder.Length == 0)
                return null;

            for (int i = 0; i < inOrder.Length; i++)
            {
                dict.Add(inOrder[i], i);
            }

            Index pIndex = new Index();
            pIndex.index = postOrder.Length - 1;
            return BuildBT(postOrder, inOrder, 0, postOrder.Length - 1, pIndex);
        }

        private BinaryTreeNode<T> BuildBT(T[] postOrder, T[] inOrder, int inStrt, int inEnd, Index pIndex)
        {
            if (inStrt > inEnd )
                return null;

            T data = postOrder[pIndex.index];
            BinaryTreeNode<T> binaryTree = new BinaryTreeNode<T>(data);
            (pIndex.index)--;

            /* If this node has no children then return */
            if (inStrt == inEnd)
                return binaryTree;

            /* Else find the index of this node in Inorder traversal */
            int iIndex = search(binaryTree.Data);

            /*  Using index in Inorder traversal, construct left and
                right subtress */

            binaryTree.Right = BuildBT(postOrder, inOrder, iIndex + 1, inEnd, pIndex);
            binaryTree.Left = BuildBT(postOrder, inOrder, inStrt, iIndex - 1, pIndex);

            return binaryTree;
        }

        private int search( T data)
        {
            return dict.ContainsKey(data) ? dict[data] : 0;
            
        }
    }

    // Class Index created to implement
    // pass by reference of Index
    public class Index
    {
        public int index;
    }

    public class TreeFromInOrderAndLeveOrder<T>
    {
        Dictionary<T, int> dict = new Dictionary<T, int>();
        static int index = 0;
        public BinaryTreeNode<T> BuildBinaryTree(T[] levelOrder, T[] inOrder)
        {
            for (int i = 0; i < inOrder.Length; i++)
                dict.Add(inOrder[i], i);
            Index pIndex = new Index();
            BinaryTreeNode<T> startnode = null;
            return constructTree(startnode, levelOrder, inOrder, 0, inOrder.Length - 1);
        }
        private BinaryTreeNode<T> constructTree(BinaryTreeNode<T> startnode, T[] levelOrder, T[] inOrder, int start, int end)
        {
            // if start index is more than end index
            if (start > end )
                return null;

            if (start == end)
                return new BinaryTreeNode<T>(inOrder[start]);

            bool found = false;
            int index = 0;

            // it represents the index in inOrder
            // array of element that appear first
            // in levelOrder array.
            for (int i = 0; i < levelOrder.Length - 1; i++)
            {
                T data = levelOrder[i];
                for (int j = start; j < end; j++)
                {
                    if (data.Equals(inOrder[j]))
                    {
                        startnode = new BinaryTreeNode<T>(data);
                        index = j;
                        found = true;
                        break;
                    }
                }
                if (found == true)
                {
                    break;
                }
            }

            // elements present before index are
            // part of left child of startNode.
            // elements present after index are
            // part of right child of startNode.
            startnode.Left
                = constructTree(startnode, levelOrder, inOrder,
                                start, index - 1);
            startnode.Right
                = constructTree(startnode, levelOrder, inOrder,
                                index + 1, end);
            
            return startnode;


        }
    }
}
