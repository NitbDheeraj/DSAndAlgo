using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees.BinarySearchTrees;

namespace TreesTest.BinarySearchTreeTest
{
    [TestClass]
    public class CheckBSTTest
    {
        [TestMethod]
        public void CheckIfBST()
        {
            CheckIfBST chk = new CheckIfBST();
            BSTNode<int> binaryTree = TestDataForBST.CreateBinaryTree();
            BSTNode<int> nonBST = TestDataForBST.CreateNonBST();
            Assert.IsTrue(chk.CheckBST(binaryTree));
            Assert.IsTrue(chk.CheckBSTEfficiently(binaryTree));
            Assert.IsTrue(chk.CheckBSTUsingInorder(binaryTree));
            Assert.IsFalse(chk.CheckBST(nonBST));
            Assert.IsFalse(chk.CheckBSTEfficiently(nonBST));
            Assert.IsFalse(chk.CheckBSTUsingInorder(nonBST));
            //              6
            //             / \
            //            2   8
            //           / \ 
            //          1   9  

            BSTNode<int> root = new BSTNode<int>(6);

            BSTNode<int> right = new BSTNode<int>(8);
            root.Right = right;
            BSTNode<int> left = new BSTNode<int>(2);
            BSTNode<int> leftLeft = new BSTNode<int>(1);
            BSTNode<int> leftRight = new BSTNode<int>(9);
            root.Left = left;
            root.Left.Left = leftLeft;
            root.Left.Right = leftRight;
            Assert.IsFalse(chk.CheckBST(root));
            Assert.IsFalse(chk.CheckBSTEfficiently(root));
            Assert.IsFalse(chk.CheckBSTUsingInorder(root));
        }
    }
}
