using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //Given a binary tree, print all root-to-leaf paths
    public class AllRootsToLeavesPath
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
}
