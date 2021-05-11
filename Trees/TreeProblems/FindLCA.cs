using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{

    /*  Let T be a rooted tree. The lowest common ancestor between two nodes n1 and n2 is defined as
     *  the lowest node in T that has both n1 and n2 as descendants (where we allow a node to be a descendant of itself).
     *  The LCA of n1 and n2 in T is the shared ancestor of n1 and n2 that is located farthest from the root. 
     *  Computation of lowest common ancestors may be useful, for instance, as part of a procedure for determining the distance between pairs of nodes in a tree: 
     *  the distance from n1 to n2 can be computed as the distance from the root to n1, plus the distance from the root to n2, 
     *  minus twice the distance from the root to their lowest common ancestor.
    //              1
    //             / \
    //            2   3
    //           / \ / \
    //          4  5 6  7 
    LCA(4,5) = 2
    LCA(4,6) = 1
    */

    public class FindLCA
    {
        private ArrayList path1 = new ArrayList();
        private ArrayList path2 = new ArrayList();

        /*  following is a simple O(n) algorithm to find LCA of n1 and n2. 
            1) Find a path from the root to n1 and store it in a vector or array. 
            2) Find a path from the root to n2 and store it in another vector or array. 
            3) Traverse both paths till the values in arrays are the same. Return the common element just before the mismatch. 
        */
        [STAThread]
        public int findLCA(BinaryTreeNode<int> binaryTree, BinaryTreeNode<int> node1, BinaryTreeNode<int> node2)
        {
            if (!findPath(binaryTree, node1, path1) || !findPath(binaryTree, node2, path2))
                return -1;

            int i;
            for (i = 0; i < path1.Count && i < path2.Count; i++)
            {
                if ((int)path1[i] != (int)path2[i])
                    break;
            }
            return (int)path1[i - 1];
        }

        // Finds the path from root node to given root of the tree, Stores the path in a vector
        // path[], returns true if path exists otherwise false
        [STAThread]
        private bool findPath(BinaryTreeNode<int> root, BinaryTreeNode<int> n, ArrayList path)
        {
            // base case
            if (root == null)
                return false;

            // Store this node. The node will be removed if not in path from root to n.
            path.Add(root.Data);

            if (root.Data == n.Data)
                return true;

            if (root.Left != null && findPath(root.Left, n, path))
                return true;

            if (root.Right != null && findPath(root.Right, n, path))
                return true;

            // If not present in subtree rooted with root, remove root from path[] and return false
            path.RemoveAt(path.Count - 1);

            return false;
        }

    }
}
