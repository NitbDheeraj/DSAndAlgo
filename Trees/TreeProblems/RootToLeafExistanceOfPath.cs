using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.TreeProblems
{
    public class RootToLeafExistanceOfPath
    {

        public bool PrintMaxSumRootToLeaf(Node root, int sum)
        {
            //base case
            if (root == null && sum == 0)
                return true;

            if (root == null)
                return false;

            //recur left subtree with the reduced sum
            bool left = PrintMaxSumRootToLeaf(root.left, sum - root.data);

            bool right = false;

            if (!left)
                right = PrintMaxSumRootToLeaf(root.right, sum - root.data);

            // print the current node if it lies on a path with a given sum
            if (left || right)
            {
                Console.WriteLine(root.data + " ");
            }

            return left || right;

        }
    }
}
