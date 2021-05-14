using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class ShortestPathbw2Nodes
    {
        //This is basically finding LCA between 2 nodes
        public BSTNode<int> ShortestPathBetween2Node(BSTNode<int> root, BSTNode<int> node1, BSTNode<int> node2)
        {
            BSTNode<int> left, right;
            if (root == null)
                return null;

            if (root.Data == node1.Data || root.Data == node2.Data)
                return root;

            left = ShortestPathBetween2Node(root.Left, node1, node2);
            right = ShortestPathBetween2Node(root.Right, node1, node2);

            if (left != null && right != null)
                return root;
            else
                return (left != null) ? left : right;

        }
    }
}
