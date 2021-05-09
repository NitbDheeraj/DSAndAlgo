using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace TreesTest
{
    public static class TestData
    {
        //  Create a binary tree
        //              1
        //             / \
        //            2   3
        //           / \ / \
        //          4  5 6  7 
        public static BinaryTreeNode<int> CreateBinaryTree()
        {
            BinaryTreeNode<int> binaryTree = new BinaryTreeNode<int>(1);

            BinaryTreeNode<int> leftNode = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> leftLeftChild = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> leftRightChild = new BinaryTreeNode<int>(5);
            leftNode.SetLeft(leftLeftChild);
            leftNode.SetRight(leftRightChild);

            BinaryTreeNode<int> rightNode = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> rightLeftChild = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> rightRightChild = new BinaryTreeNode<int>(7);
            rightNode.SetLeft(rightLeftChild);
            rightNode.SetRight(rightRightChild);

            binaryTree.SetLeft(leftNode);
            binaryTree.SetRight(rightNode);

            return binaryTree;
        }

        //  Create a binary tree
        //              1
        //             / \
        //            2   3
        //           / \ / 
        //          4  5 6   
        public static BinaryTreeNode<int> CreateBinaryTree1()
        {
            BinaryTreeNode<int> binaryTree = new BinaryTreeNode<int>(1);

            BinaryTreeNode<int> leftNode = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> leftLeftChild = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> leftRightChild = new BinaryTreeNode<int>(5);
            leftNode.SetLeft(leftLeftChild);
            leftNode.SetRight(leftRightChild);

            BinaryTreeNode<int> rightNode = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> rightLeftChild = new BinaryTreeNode<int>(6);
            rightNode.SetLeft(rightLeftChild);

            binaryTree.SetLeft(leftNode);
            binaryTree.SetRight(rightNode);

            return binaryTree;
        }

        //  Create a binary tree
        //              5
        //             / \
        //            6   7
        //           / \ / 
        //          8  9 9   
        public static BinaryTreeNode<int> CreateBinaryTree2()
        {
            BinaryTreeNode<int> binaryTree = new BinaryTreeNode<int>(5);

            BinaryTreeNode<int> leftNode = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> leftLeftChild = new BinaryTreeNode<int>(8);
            BinaryTreeNode<int> leftRightChild = new BinaryTreeNode<int>(9);
            leftNode.SetLeft(leftLeftChild);
            leftNode.SetRight(leftRightChild);

            BinaryTreeNode<int> rightNode = new BinaryTreeNode<int>(7);
            BinaryTreeNode<int> rightLeftChild = new BinaryTreeNode<int>(9);
            rightNode.SetLeft(rightLeftChild);

            binaryTree.SetLeft(leftNode);
            binaryTree.SetRight(rightNode);

            return binaryTree;
        }


        // Create a binary tree
        //     1
        //    /  \
        //   2    3
        // /  \     \
        //4    5     8 
        //          /  \
        //         6    7

        public static BinaryTreeNode<int> CreateBinaryTree3()
        {
            BinaryTreeNode<int> binaryTree = new BinaryTreeNode<int>(1);

            BinaryTreeNode<int> leftNode = new BinaryTreeNode<int>(2);
            BinaryTreeNode<int> leftLeftChild = new BinaryTreeNode<int>(4);
            BinaryTreeNode<int> leftRightChild = new BinaryTreeNode<int>(5);
            leftNode.SetLeft(leftLeftChild);
            leftNode.SetRight(leftRightChild);

            BinaryTreeNode<int> rightNode = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> rightrightChild = new BinaryTreeNode<int>(8);
            BinaryTreeNode<int> rightrightLeftChild = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> rightrightrightChild = new BinaryTreeNode<int>(7);
            rightrightChild.SetLeft(rightrightLeftChild);
            rightrightChild.SetRight(rightrightrightChild);
            rightNode.SetRight(rightrightChild);

            binaryTree.SetLeft(leftNode);
            binaryTree.SetRight(rightNode);

            return binaryTree;
        }
    }
}
