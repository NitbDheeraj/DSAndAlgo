using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.TreeProblems;

namespace Trees
{
    public static class TreeProblem
    {
        // binary tree
        //              1
        //             / \
        //            2   3
        //           / \ / \
        //          4  5 6  7
        public static void TreeProblemAndSolutions(BinaryTreeNode<int> binaryTree)
        {
            Console.WriteLine("Finding Max Value in binary tree!");
            FindMaxElement<int> fM = new FindMaxElement<int>();
            Console.Write("Max value found recursively in this tree is " + fM.FindMaxRecursively(binaryTree));
            Console.WriteLine();
            Console.Write("Max value found iteratively in this tree is " + fM.FindMaxIteratively(binaryTree));
            Console.WriteLine("\n");

            SearchAnElement sE = new SearchAnElement();
            Console.WriteLine("Searching for an element in binary tree!");
            Console.WriteLine("Searching for 10 in binary tree results in " + sE.SearchElementRecursively(binaryTree, 10));
            Console.WriteLine("Searching for 5 in binary tree results in " + sE.SearchElementRecursively(binaryTree, 5));
            Console.WriteLine("Searching for 12 in binary tree results in " + sE.SearchElementIteratively(binaryTree, 12));
            Console.WriteLine("Searching for 6 in binary tree results in " + sE.SearchElementIteratively(binaryTree, 2));
            Console.WriteLine("\n");

            FindSizeOfBinaryTree fs = new FindSizeOfBinaryTree();
            Console.WriteLine("Size of this binarytree searched recursively is " + fs.FindSizeRecursively(binaryTree));
            Console.WriteLine("Size of this binarytree searched iteratively is " + fs.FindSizeIteratively(binaryTree));
            Console.WriteLine("\n");

            ReverseLevelOrder rLO = new ReverseLevelOrder();
            Console.Write("Reversing level order traversl prints " );
            rLO.LevelOrderReversal(binaryTree);
            Console.WriteLine("\n");

            FindHeight fH = new FindHeight();
            Console.Write("Height of given binary tree is " + fH.FindHeightOfTree(binaryTree));
            Console.Write("\nHeight of given binary tree calculated iteratively is " + fH.FindHeightIteratively(binaryTree));
            Console.WriteLine("\n");

            FindMinDepth tree = new FindMinDepth();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            Console.WriteLine("The minimum depth of binary tree is : " + tree.minimumDepth());
            Console.WriteLine("\n");

            FindNumberOfLeaves fNL = new FindNumberOfLeaves();
            Console.Write("Number of leaves in given binary tree is " + fNL.FindNumberOfLeave(binaryTree));
            Console.WriteLine("\n");

            FindNumberOfFullNodes fullNode = new FindNumberOfFullNodes();
            Console.Write("Number of full nodes in given binary tree is " + fullNode.FindNumberOfFullNode(binaryTree));
            Console.WriteLine("\n");

            AllRootsToLeavesPath allPath = new AllRootsToLeavesPath();
            allPath.PrintAllRootToLeavesPath(binaryTree);



        }
    }
}
