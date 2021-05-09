using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    [TestClass]
    public class TreeProblemsTest
    {
        [TestMethod]
        public void IdenticalBinaryTreesTest()
        {
            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree();
            BinaryTreeNode<int> binaryTree2 = TestData.CreateBinaryTree();
            BinaryTreeNode<int> binaryTree3 = TestData.CreateBinaryTree1();
            IdenticalBinaryTrees iBT = new IdenticalBinaryTrees();

            Assert.IsTrue(iBT.IdenticalTrees(binaryTree1, binaryTree2));

            Assert.IsFalse(iBT.IdenticalTrees(binaryTree1, binaryTree3));

        }

        [TestMethod]
        public void StructurallySimilarTreesTest()
        {
            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree();
            BinaryTreeNode<int> binaryTree2 = TestData.CreateBinaryTree1();
            BinaryTreeNode<int> binaryTree3 = TestData.CreateBinaryTree2();
            CheckIf2BinaryTreesAreSimilar similarTree = new CheckIf2BinaryTreesAreSimilar();

            Assert.IsTrue(similarTree.CheckForSimilarity(binaryTree3, binaryTree2));

            Assert.IsFalse(similarTree.CheckForSimilarity(binaryTree1, binaryTree2));

        }

        [TestMethod]
        public void DiameterOfBinaryTree()
        {
            BinaryTreeNode<int> binaryTree1 = TestData.CreateBinaryTree();
            BinaryTreeNode<int> binaryTree2 = TestData.CreateBinaryTree1();
            DiameterOfBinaryTree diameter = new DiameterOfBinaryTree();

            Assert.AreEqual(diameter.Diameter(binaryTree1), 5);

            Assert.AreEqual(diameter.Diameter(binaryTree2), 5);

        }
    }
}
