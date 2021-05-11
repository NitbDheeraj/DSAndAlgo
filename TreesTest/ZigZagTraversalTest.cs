using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Trees;
using Trees.Traversal;

namespace TreesTest
{
    [TestClass]
    public class ZigZagTraversalTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //  Create a binary tree
            //              1
            //             / \
            //            2   3
            //           / \ / \
            //          4  5 6  7 
            
            var expectedOutput = "1324567";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
                ZigZagTraversal zigZagTraversal = new ZigZagTraversal();
                zigZagTraversal.PrintZigZagTraversal(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            //  Create a binary tree
            //              1
            //             / \
            //            2   3
            //           / \ / \
            //          4  5 6  7 



            var expectedOutput = "1324567";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
                ZigZagTraversal zigZagTraversal = new ZigZagTraversal();
                zigZagTraversal.PrintZigZagTraversal1(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        // Create a binary tree
        //     1
        //    /  \
        //   2    3
        // /  \     \
        //4    5     8 
        //          /  \
        //         6    7
        [TestMethod]
        public void TestMethod3()
        {

            var expectedOutput = "13245876";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree3();
                ZigZagTraversal zigZagTraversal = new ZigZagTraversal();
                zigZagTraversal.PrintZigZagTraversal(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

        // Create a binary tree
        //     1
        //    /  \
        //   2    3
        // /  \     \
        //4    5     8 
        //          /  \
        //         6    7
        [TestMethod]
        public void TestMethod4()
        {

            var expectedOutput = "13245876";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree3();
                ZigZagTraversal zigZagTraversal = new ZigZagTraversal();
                zigZagTraversal.PrintZigZagTraversal1(binaryTree);
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }

    }
}
