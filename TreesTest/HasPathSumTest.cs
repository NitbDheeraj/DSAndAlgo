using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    [TestClass]
    public class HasPathSumTest
    {
        [TestMethod]
        public void TestHasPathSum()
        {
            CheckPathWithAGivenSum chkPath = new CheckPathWithAGivenSum();
            //  Create a binary tree
            //              1
            //             / \
            //            2   3
            //           / \ / \
            //          4  5 6  7 
            BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
            Assert.IsTrue(chkPath.HasPathSum(binaryTree, 7));
            Assert.IsFalse(chkPath.HasPathSum(binaryTree, 4));

            // Create a binary tree
            //     1
            //    /  \
            //   2    3
            // /  \     \
            //4    5     8 
            //          /  \
            //         6    7
            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree3();
            Assert.IsTrue(chkPath.HasPathSum(binaryTree1, 7));
            Assert.IsTrue(chkPath.HasPathSum(binaryTree1, 19));
            Assert.IsFalse(chkPath.HasPathSum(binaryTree1, 4));


        }
    }
}
