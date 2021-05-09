using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Trees;
using Trees.Traversal;

namespace TreesTest
{
    [TestClass]
    public class TraversalTests
    {
        //  Create a binary tree
        //              1
        //             / \
        //            2   3
        //           / \ / \
        //          4  5 6  7 
        public BinaryTreeNode<int> CreateBinaryTree()
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

        [TestMethod]
        public void PreOrderTraversalTest()
        {
            var expectedOutput = "1245367";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                PreOrderTraversal<int> pOT = new PreOrderTraversal<int>();
                pOT.PreOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void IterativePreOrderTraversalTest()
        {
            var expectedOutput = "1245367";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                PreOrderTraversal<int> pOT = new PreOrderTraversal<int>();
                pOT.IterativePreOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void InOrderTraversalTest()
        {
            var expectedOutput = "4251637";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                InOrderTraversal<int> iOT = new InOrderTraversal<int>();
                iOT.InOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void IterativeInOrderTraversalTest()
        {
            var expectedOutput = "4251637";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                InOrderTraversal<int> iOT = new InOrderTraversal<int>();
                iOT.IterativeInOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void PostOrderTraversalTest()
        {
            var expectedOutput = "4526731";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                PostOrderTraversal<int> poOT = new PostOrderTraversal<int>();
                poOT.PostOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void IterativePostOrderTraversalTest()
        {
            var expectedOutput = "4526731";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                PostOrderTraversal<int> poOT = new PostOrderTraversal<int>();
                poOT.IterativePostOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void LevelOrderTraversalTest()
        {
            var expectedOutput = "1234567";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = CreateBinaryTree();
                LevelOrderTraversal<int> lOT = new LevelOrderTraversal<int>();
                lOT.LevelOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }
    }
}
