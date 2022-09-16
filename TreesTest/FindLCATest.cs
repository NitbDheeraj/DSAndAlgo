using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    [TestClass]
    public class FindLCATest
    {
        [TestMethod]
        public void TestLCA()
        {
            // Create a binary tree
            //     1
            //    /  \
            //   2    3
            // /  \     \
            //4    5     8 
            //          /  \
            //         6    7

            BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree3();
            FindLeastCommonAncestor findLCA = new FindLeastCommonAncestor();

            Assert.AreEqual(1, findLCA.findLCA(binaryTree, new BinaryTreeNode<int>(6), new BinaryTreeNode<int>(5)));

            //Assert.AreEqual(8, findLCA.findLCA(binaryTree, new BinaryTreeNode<int>(6), new BinaryTreeNode<int>(7)));

        }
    }
}
