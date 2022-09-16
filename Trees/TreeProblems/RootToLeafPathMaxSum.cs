using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    public class RootToLeafPathMaxSum
    {
        // Function to calculate maximum root to leaf sum in binary tree
        public int MaxSumRootToLeaf(Node root)
        {
            //Base Case
            if (root == null)
                return 0;

            // Current Node is a leaf node
            if (root.left == null && root.right == null)
                return root.data;

            //Calculate max node to leaf sum for left child
            int left = MaxSumRootToLeaf(root.left);

            //calculate max node to leaf sum for right child
            int right = MaxSumRootToLeaf(root.right);

            return (left > right ? left : right) + root.data;
        }
    }
}
