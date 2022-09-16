using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Given a binary tree, print all root-to-leaf paths
    public class RootsToLeavesPathAll
    {
        public void PrintAllRootToLeavesPath(BinaryTreeNode<int> binaryTree)
        {
            int[] path = new int[100];
            PrintPathRecursively(binaryTree, path, 0);
        }

        private void PrintPathRecursively(BinaryTreeNode<int> binaryTree, int[] path, int v)
        {
            if (binaryTree == null)
                return;

            path[v] = binaryTree.Data;
            v++;

            if(binaryTree.Left == null && binaryTree.Right == null)
            {
                PrintArray(path, v);
            }
            else
            {
                PrintPathRecursively(binaryTree.Left, path, v);
                PrintPathRecursively(binaryTree.Right, path, v);
            }
        }

        private void PrintArray(int[] path, int v)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < v; i++)
                sb.Append(path[i]);
                
             Console.WriteLine(sb.ToString());
            
        }
    }

    public class PrintRootToLeafPath
    {

        // The main function to print paths from the root node to every leaf node
        public void printRootToLeaf(Node node)
        {
            // list to store root-to-leaf path
            List<int> path = new List<int>();
            printRootToLeafPathsMain(node, path);
        }

        public void printRootToLeafPathsMain(Node node, List<int> path)
        {
            if (node == null)
                return;

            // include the current node to the path
            path.Add(node.data);

            // if a leaf node is found, print the path
            if (node.left == null && node.right == null)
            {
                Console.WriteLine(path);
            }

            // recur for the left and right subtree
            printRootToLeafPathsMain(node.left, path);
            printRootToLeafPathsMain(node.right, path);

            // backtrack: remove the current node after the left, and right subtree are done
            // Remove last node
            if(path.Count() > 0)
                path.RemoveAt(path.Count() - 1);

        }
    }

}
