using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees.BinarySearchTrees;

namespace TreesTest.BinarySearchTreeTest
{
    [TestClass]
    public class FindANodeTest
    {
        [TestMethod]
        public void FindNode()
        {
            BSTNode<int> binaryTree = TestDataForBST.CreateBinaryTree();

            FindAnElementInBST findAnElementInBST = new FindAnElementInBST();

            Assert.AreEqual(findAnElementInBST.FindANode(binaryTree, new BSTNode<int>(5)).Data, new BSTNode<int>(5).Data);

            Assert.AreEqual(findAnElementInBST.FindANodeIteratively(binaryTree, new BSTNode<int>(5)).Data, new BSTNode<int>(5).Data);

        }

        [TestMethod]
        public void FindMinNode()
        {
            BSTNode<int> binaryTree = TestDataForBST.CreateBinaryTree();
            FindAnElementInBST findAnElementInBST = new FindAnElementInBST();
            int min = findAnElementInBST.FindMinimum(binaryTree).Data;
            Assert.AreEqual(min, 2);

            Assert.AreEqual(findAnElementInBST.FindMinimumIteratively(binaryTree).Data, 2);
        }

        [TestMethod]
        public void FindMaxNode()
        {
            BSTNode<int> binaryTree = TestDataForBST.CreateBinaryTree();
            FindAnElementInBST findAnElementInBST = new FindAnElementInBST();
            int min = findAnElementInBST.FindMaximum(binaryTree).Data;
            Assert.AreEqual(min, 10);

            Assert.AreEqual(findAnElementInBST.FindMaximumIteratively(binaryTree).Data, 10);
        }
    }
}
