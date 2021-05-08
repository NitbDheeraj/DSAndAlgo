using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Traversal;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a binary tree
            //              1
            //             / \
            //            2   3
            //           / \ / \
            //          4  5 6  7
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

            //Represents all traversal for binary tree
            //AllTraversal.AllTraversals(binaryTree);

            TreeProblem.TreeProblemAndSolutions(binaryTree);


            Console.ReadLine();
        }
    }
}
