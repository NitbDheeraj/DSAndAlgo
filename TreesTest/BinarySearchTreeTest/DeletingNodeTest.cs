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
    public class DeletingANodeInBSTTest
    {
        [TestMethod]
        public void DeleteNodeTest()
        {
            //              7
            //             / \
            //            4   9
            //           / \ / \
            //          2  5 8  10 
            var expectedOutput = "Error!!";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                BSTNode<int> binaryTree = TestDataForBST.CreateBinaryTree();
                DeleteANode d = new DeleteANode();
                binaryTree = d.DeleteNode(binaryTree, new BSTNode<int>(12));
                Assert.AreEqual<string>(expectedOutput, sw.ToString());

                binaryTree = d.DeleteNode(binaryTree, new BSTNode<int>(2));

                Assert.IsNull(binaryTree.Left.Left);

                InsertANode i = new InsertANode();
                binaryTree = i.InsertANodeInBST(binaryTree, new BSTNode<int>(2));
                binaryTree = i.InsertANodeInBST(binaryTree, new BSTNode<int>(1));

                binaryTree = d.DeleteNode(binaryTree, new BSTNode<int>(2));
                Assert.AreEqual(binaryTree.Left.Left.Data, 1);

                binaryTree = d.DeleteNode(binaryTree, new BSTNode<int>(9));
                Assert.AreEqual(binaryTree.Right.Data, 8);
                Assert.AreEqual(binaryTree.Right.Right.Data, 10);

            }


        }

    }
}
