using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    [TestClass]
    public class TreeWidthTest
    {
        [TestMethod]
        public void MaxTreeWidthTest()
        {
            BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree3();
            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree();

            MaxTreeWidth mTW = new MaxTreeWidth();

            Assert.AreEqual(3, mTW.MaxWidthUsingLevelOrder(binaryTree));

            Assert.AreEqual(4, mTW.MaxWidthUsingLevelOrder(binaryTree1));
        }
    }
}
