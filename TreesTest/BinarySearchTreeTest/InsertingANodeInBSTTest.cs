using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinarySearchTrees;

namespace TreesTest.BinarySearchTreeTest
{
    [TestClass]
    public class InsertingANodeInBSTTest
    {
        [TestMethod]
        public void InsertNodeTest()
        {
            var expectedOutput = "Node Inserted Successfully";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BSTNode<int> binaryTree = TestDataForBST.CreateBinaryTree();
                InsertANode i = new InsertANode();
                binaryTree = i.InsertANodeInBST(binaryTree, new BSTNode<int>(12));
                Assert.AreEqual<string>(expectedOutput, sw.ToString());

                FindAnElementInBST findNode = new FindAnElementInBST();

                Assert.AreEqual(findNode.FindMaximum(binaryTree).Data, 12);

                Assert.IsNull(findNode.FindANode(binaryTree, new BSTNode<int>(12).Left));
                Assert.IsNull(findNode.FindANode(binaryTree, new BSTNode<int>(12).Right));

            }


        }

    }
}
