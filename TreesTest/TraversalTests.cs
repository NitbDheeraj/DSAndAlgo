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
        

        [TestMethod]
        public void PreOrderTraversalTest()
        {
            var expectedOutput = "1245367";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
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

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
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

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
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

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
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

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
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

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
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

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
                LevelOrderTraversal<int> lOT = new LevelOrderTraversal<int>();
                lOT.LevelOrder(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }
    }
}
