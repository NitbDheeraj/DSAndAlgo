using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Trees;
using Trees.TreeProblems;

namespace TreesTest
{
    /// <summary>
    /// Summary description for PrintAncestorsTest
    /// </summary>
    [TestClass]
    public class PrintAncestorsTest
    {
        [TestMethod]
        public void CheckAncestors()
        {
            var expectedOutput = "31";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BinaryTreeNode<int> binaryTree = TestData.CreateBinaryTree();
                PrintAncesters<int> pOT = new PrintAncesters<int>();
                pOT.PrintAncestersOfANode(binaryTree, new BinaryTreeNode<int>(7));
                Assert.AreEqual<string>(expectedOutput, sw.ToString());
            }
        }
    }
}
