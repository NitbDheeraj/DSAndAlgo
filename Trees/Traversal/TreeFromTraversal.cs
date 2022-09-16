using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.TreeProblems;

namespace Trees.Traversal
{

    //Preorder and Inorder
    public class TreeFromTraversal
    {
        // Store indexes of all items so that we
        // we can quickly find later
        static Dictionary<int, int> mp = new Dictionary<int, int>();
        static int preIndex = 0;


        public Node BuildBinaryTree(int[] preOrder, int[] inOrder)
        {
            if (preOrder.Length == 0 && inOrder.Length == 0)
                return null;

            for (int i = 0; i < inOrder.Length; i++)
            {
                mp.Add(inOrder[i], i);
            }

            return BuildBT(preOrder, inOrder, 0, preOrder.Length - 1);
        }

        /* Recursive function to construct binary of size len from Inorder traversal in[] and Preorder traversal
            pre[]. Initial values of inStrt and inEnd should be 0 and len -1. The function doesn't do any error
            checking for cases where inorder and preorder do not form a tree 
        */
        private Node BuildBT(int[] preOrder, int[] inOrder, int inStrt, int inEnd)
        {
            //Base Case
            if (inStrt > inEnd)
            {
                return null;
            }

            int data = preOrder[preIndex++];
            Node binaryTree = new Node(data);

            /* Else find the index of this node in Inorder traversal */
            int inIndex = mp[data];

            /*  Using index in Inorder traversal, construct left and
                right subtress */
            binaryTree.left = BuildBT(preOrder, inOrder, inStrt, inIndex - 1);
            binaryTree.right = BuildBT(preOrder, inOrder, inIndex + 1, inEnd);

            return binaryTree;
        }

    }


    /* Give an algorithm for constructing binary tree from given Inorder and Postorder traversals. */
    public class TreeFromInorderAndPostOrder
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public Node BuildBinaryTree(int[] postOrder, int[] inOrder)
        {
            if (postOrder.Length == 0 && inOrder.Length == 0)
                return null;

            for (int i = 0; i < inOrder.Length; i++)
            {
                dict.Add(inOrder[i], i);
            }

            ReferenceIndex pIndex = new ReferenceIndex();
            pIndex.index = postOrder.Length - 1;
            return BuildBT(postOrder, inOrder, 0, postOrder.Length - 1, pIndex);
        }

        private Node BuildBT(int[] postOrder, int[] inOrder, int inStrt, int inEnd, ReferenceIndex pIndex)
        {
            if (inStrt > inEnd)
                return null;

            int data = postOrder[pIndex.index];
            Node binaryTree = new Node(data);
            (pIndex.index)--;

            /* If this node has no children then return */
            if (inStrt == inEnd)
                return binaryTree;

            /* Else find the index of this node in Inorder traversal */
            int iIndex = search(binaryTree.data);

            /*  Using index in Inorder traversal, construct left and
                right subtress */

            binaryTree.right = BuildBT(postOrder, inOrder, iIndex + 1, inEnd, pIndex);
            binaryTree.left = BuildBT(postOrder, inOrder, inStrt, iIndex - 1, pIndex);

            return binaryTree;
        }

        private int search(int data)
        {
            return dict.ContainsKey(data) ? dict[data] : 0;

        }
    }

    // Class Index created to implement
    // pass by reference of Index
    public class ReferenceIndex
    {
        public int index;
    }

}
