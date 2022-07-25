using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class BoundaryTraversal
    {


        public static void performBoundaryTraversal(Node root)
        {
            // base case
            if (root == null)
            {
                return;
            }

            // print the root node
            Console.WriteLine(root.data + " ");

            // print the left boundary (except leaf nodes)
            printLeftBoundary(root.left);

            // print all leaf nodes
            if (!root.isLeaf())
            {
                printLeafNodes(root);
            }

            // print the right boundary (except leaf nodes)
            printRightBoundary(root.right);
        }

        private static void printLeftBoundary(Node left)
        {
            // base case: root is empty
            if (left == null)
            {
                return;
            }

            Node node = left;

            // do for all non-leaf nodes
            while (!node.isLeaf())
            {
                // print the current node
                Console.WriteLine(node.data + " ");

                // next process, the left child of `root` if it exists;
                // otherwise, move to the right child
                node = (node.left != null) ? node.left : node.right;
            }
        }

        // Recursive function to print the leaf nodes of the given
        // binary tree in an inorder fashion
        public static void printLeafNodes(Node root)
        {
            // base case
            if (root == null)
            {
                return;
            }

            // recur for the left subtree
            printLeafNodes(root.left);

            // print only leaf nodes
            if (root.isLeaf())
            {
                Console.WriteLine(root.data + " ");
            }

            // recur for the right subtree
            printLeafNodes(root.right);
        }
        public static void printRightBoundary(Node root)
        {
            // base case: root is empty, or root is a leaf node
            if (root == null || root.isLeaf())
            {
                return;
            }

            // recur for the right child of `root` if it exists;
            // otherwise, recur for the left child
            printRightBoundary(root.right != null ? root.right : root.left);

            // To ensure bottom-up order, print the value of the nodes
            // after recursion unfolds
            Console.WriteLine(root.data + " ");
        }


        public void Test()
        {
            // construct a binary tree as per the above diagram
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            root.left.left.left = new Node(8);
            root.left.left.right = new Node(9);
            root.left.right.right = new Node(10);
            root.right.right.left = new Node(11);
            root.left.left.right.left = new Node(12);
            root.left.left.right.right = new Node(13);
            root.right.right.left.left = new Node(14);

            performBoundaryTraversal(root);
        }
    }

    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            this.left = this.right = null;
        }

        // Utility function to check if a given node is a leaf node
        public bool isLeaf()
        {
            return this.left == null && this.right == null;
        }
    }
}
