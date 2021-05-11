using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Give an algorithm for printing all the ancestors of a node in a Binary tree. For the tree below, for 7 the ancestors are 1 3 7.
    //              1
    //             / \
    //            2   3
    //           / \ / \
    //          4  5 6  7 
    public class PrintAncesters<T>
    { 
        public bool PrintAncestersOfANode(BinaryTreeNode<T> binaryTree, BinaryTreeNode<T> node)
        {
            if (binaryTree == null)
                return false;

            if (binaryTree.Data.Equals(node.Data))
                return true;

            if(PrintAncestersOfANode(binaryTree.Left, node) || PrintAncestersOfANode(binaryTree.Right, node))
            {
                Console.Write(binaryTree.Data);
                return true;
            }
            return false;
        }
    }
}
