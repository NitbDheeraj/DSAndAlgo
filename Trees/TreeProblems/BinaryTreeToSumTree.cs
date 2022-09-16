using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{

    /*
     * Given a Binary Tree where each node has positive and negative values. 
     * Convert this to a tree where each node contains the sum of the left and right sub trees in the original tree.
     * The values of leaf nodes are changed to 0.

        For example, the following tree  

                  10
               /      \
             -2        6
           /   \      /  \ 
         8     -4    7    5

        should be changed to 

                 20(4-2+12+6)
               /      \
         4(8-4)      12(7+5)
           /   \      /  \ 
         0      0    0    0
     * 
     */


    /* Solution: 
        Do a traversal of the given tree. 
        In the traversal, store the old value of the current node, 
        recursively call for left and right subtrees and change the value of current node as sum of the values returned by the recursive calls.
        Finally return the sum of new value and value (which is sum of values in the subtree rooted with this node). 
     */
    public class BinaryTreeToSumTree
    {
        // Convert a given tree to a tree where
        // every node contains sum of values of
        // nodes in left and right subtrees in
        // the original tree
        public virtual int toSumTree(Node node)
        {
            // Base case
            if (node == null)
            {
                return 0;
            }

            // Store the old value
            int old_val = node.data;

            // Recursively call for left and
            // right subtrees and store the sum
            // as new value of this node
            node.data = toSumTree(node.left) + toSumTree(node.right);

            // Return the sum of values of nodes
            // in left and right subtrees old_value
            // of this node
            return node.data + old_val;
        }
    }

    // A binary tree node
    public class BTNode
    {
        public int data;
        public Node left, right;

        public BTNode(int item)
        {
            data = item;
            left = right = null;
        }
    }
}
