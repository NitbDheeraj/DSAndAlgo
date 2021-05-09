using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.Traversal;

namespace TreesTest
{
    [TestClass]
    public class TreeFromTraversalTest
    {
        [TestMethod]
        public void CheckIfTreeFromPreorderAndInorderTraversal()
        {
            var inorderTraversal = new char[] { 'D', 'B', 'E', 'A', 'F', 'C' };
            var preorderTraversal = new char[] { 'A', 'B', 'D', 'E', 'C', 'F' };

            TreeFromTraversal tFT = new TreeFromTraversal();
            BinaryTreeNode<char> binaryTree = tFT.BuildBinaryTree(preorderTraversal, inorderTraversal);

            Assert.AreEqual(binaryTree.Data, 'A');
            Assert.AreEqual(binaryTree.Left.Data, 'B');
            Assert.AreEqual(binaryTree.Right.Data, 'C');
            Assert.AreEqual(binaryTree.Right.Left.Data, 'F');
            Assert.AreEqual(binaryTree.Left.Left.Data, 'D');
            Assert.AreEqual(binaryTree.Left.Right.Data, 'E');

        }

        [TestMethod]
        public void CheckIfTreeFromPostorderAndInorderTraversal()
        {
            var inorderTraversal = new int[] { 4, 8, 2, 5, 1, 6, 3, 7 };
            var postOrder = new int[] { 8, 4, 5, 2, 6, 7, 3, 1 };

            TreeFromInorderAndPostOrder<int> tFT = new TreeFromInorderAndPostOrder<int>();
            BinaryTreeNode<int> binaryTree = tFT.BuildBinaryTree(postOrder, inorderTraversal);

            Assert.AreEqual(binaryTree.Data, 1);
            Assert.AreEqual(binaryTree.Left.Data, 2);
            Assert.AreEqual(binaryTree.Right.Data, 3);
            Assert.AreEqual(binaryTree.Right.Left.Data, 6);
            Assert.AreEqual(binaryTree.Left.Left.Data, 4);
            Assert.AreEqual(binaryTree.Left.Right.Data, 5);

        }
    }
}
