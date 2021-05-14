using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    /*  The main idea of the solution is: while traversing BST from root to bottom, the first
        node we encounter with value between α and β, i.e., α < node → data < β, is the Least Common
        Ancestor(LCA) of α and β (where α < β). So just traverse the BST in pre-order, and if we find a
        node with value in between α and β, then that node is the LCA. If its value is greater than both α
        and β, then the LCA lies on the left side of the node, and if its value is smaller than both a and β,
        then the LCA lies on the right side.
    */
    public class FindLCA
    {
        private BSTNode<int> FindLCAForBST(BSTNode<int> root, BSTNode<int> node1, BSTNode<int> node2)
        {
            if (root == null)
                return null;

            if (root.Data == node1.Data || root.Data == node2.Data)
                return root;

            //// If both n1 and n2 are smaller than root, then LCA lies in left 
            if (root.Data > node1.Data && root.Data > node2.Data)
                FindLCAForBST(root.Left, node1, node2);

            // If both n1 and n2 are greater than root, then LCA lies in right
            if (root.Data < node1.Data && root.Data < node2.Data)
                FindLCAForBST(root.Left, node1, node2);

            return root;

        }
    }
}
