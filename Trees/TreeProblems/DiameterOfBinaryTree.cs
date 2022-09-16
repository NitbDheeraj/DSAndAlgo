using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    //The diameter of a tree is the number of nodes on the longest path between two leaves in the tree.
    //Give an algorithm for finding the diameter of the binary tree. The diameter of a
    //tree(sometimes called the width) is the number of nodes on the longest path between twoleaves in the tree.
    public class DiameterOfBinaryTree
    {
        private int Height(BinaryTreeNode<int> binaryTree, A a)
        {
            if (binaryTree == null)
                return 0;

            int leftHeight = Height(binaryTree.Left, a);
            int rightHeight = Height(binaryTree.Right, a);

            // update the answer, because diameter of a
            // tree is nothing but maximum value of
            // (left_height + right_height + 1) for each node
            a.ans = Math.Max(a.ans, 1 + leftHeight + rightHeight);

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public int Diameter(BinaryTreeNode<int> binaryTree)
        {
            if (binaryTree == null)
                return 0;

            A a = new A();
            int heightOfTree = Height(binaryTree, a);
            return a.ans;
        }

    }

    public class A
    {
        public int ans = int.MinValue;
    }




    public class DiameterBinaryTree
    {
        public int diameterOfBinaryTree(Node node)
        {
            if (node == null)
                return 0;

            int leftSubtreeDiameter = diameterOfBinaryTree(node.left);
            int rightSubtreeDiameter = diameterOfBinaryTree(node.right);
            int diameter = getDepth(node.left) + getDepth(node.right);
            diameter = Math.Max(diameter, Math.Max(leftSubtreeDiameter, rightSubtreeDiameter));
            return diameter;
        }

        public int getDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftSubtreeDepth = getDepth(root.left);
            int rightSubtreeDepth = getDepth(root.right);
            return Math.Max(leftSubtreeDepth, rightSubtreeDepth) + 1;
        }
    }

}
