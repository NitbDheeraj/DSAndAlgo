using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    [TestClass]
    public class BinaryTreeSumTest
    {
        [TestMethod]
        public void IterativeMethodTest()
        {
            //  Create a binary tree
            //              1
            //             / \
            //            2   3
            //           / \ / \
            //          4  5 6  7 
            BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
            FindSum fS = new FindSum();
            Assert.AreEqual(fS.FindSumIteratively(binaryTree), 28);

            // Create a binary tree
            //     1
            //    /  \
            //   2    3
            // /  \     \
            //4    5     8 
            //          /  \
            //         6    7

            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree3();
            Assert.AreEqual(fS.FindSumIteratively(binaryTree1), 36);

        }

        [TestMethod]
        public void RecursiveMethodTest()
        {
            //  Create a binary tree
            //              1
            //             / \
            //            2   3
            //           / \ / \
            //          4  5 6  7 
            BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
            FindSum fS = new FindSum();
            Assert.AreEqual(fS.FindSumRecursively(binaryTree), 28);

            // Create a binary tree
            //     1
            //    /  \
            //   2    3
            // /  \     \
            //4    5     8 
            //          /  \
            //         6    7

            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree3();
            Assert.AreEqual(fS.FindSumRecursively(binaryTree1), 36);

        }
    }
}
