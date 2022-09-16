using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    //Check if a given array can represent Preorder Traversal of Binary Search Tree
    //We will recursively visit all nodes, but we will not build the nodes. In the end, if the complete array is not traversed,
    //then that means that array can not represent the preorder traversal of any binary tree.

    public class CanBuildBSTFromPreorderarr
    {

        static int preIndex = 0;

        static bool canRepresentBST(int[] arr)
        {
            int min = Int32.MinValue, max = Int32.MaxValue;
            int N = arr.Length;

            buildBST_helper(N, arr, min, max);

            return preIndex == N;
        }

        // We are actually not building the tree
        static void buildBST_helper(int n, int[] pre, int min, int max)
        {
            if (preIndex >= n)
                return;

            if (min <= pre[preIndex] && pre[preIndex] <= max)
            {
                // build node
                int rootData = pre[preIndex];
                preIndex++;

                // build left subtree
                buildBST_helper(n, pre, min, rootData);

                // build right subtree
                buildBST_helper(n, pre, rootData, max);
            }
            // else
            // return NULL;
        }
    }
}
