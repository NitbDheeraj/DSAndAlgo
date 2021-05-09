using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    [TestClass]
    public class MaxLevelSumTest
    {
        [TestMethod]
        public void TestMaxLevelSum()
        {
            MaximumSumLevel maxSum = new MaximumSumLevel();
            BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree3();
            Assert.AreEqual(17, maxSum.MaxSumLevel(binaryTree));

            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree();
            Assert.AreEqual(22, maxSum.MaxSumLevel(binaryTree1));
        }
    }
}
