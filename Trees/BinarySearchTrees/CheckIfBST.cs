using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class CheckIfBST
    {

        /*
         * The idea behind this solution is that inorder traversal of
            BST produces sorted lists. While traversing the BST in inorder, at each node check the condition
            that its key value should be greater than the key value of its previous visited node. Also, we need
            to initialize the prev with possible minimum integer value (say, Integer. MIN_VALUE).

         */

        private int prevValue = int.MinValue;
        public bool CheckBSTUsingInorder(BSTNode<int> root)
        {
            return CheckBSTUsingInorderUtil(root);
        }

        private bool CheckBSTUsingInorderUtil(BSTNode<int> root)
        {
            if (root == null)
                return true;

            if (!CheckBSTUsingInorderUtil(root.Left))
                return false;
            if (root.Data < prevValue)
                return false;

            prevValue = root.Data;

            if (!CheckBSTUsingInorderUtil(root.Right))
                return false;

            return true;

        }

        public bool CheckBST(BSTNode<int> root)
        {
            FindAnElementInBST findNode = new FindAnElementInBST();


            if (root == null)
                return true;

            if (root.Left != null && root.Data < findNode.FindMaximum(root.Left).Data)
                return false;

            if (root.Right != null && root.Data > findNode.FindMinimum(root.Right).Data)
                return false;

            if (!CheckBST(root.Left) || !CheckBST(root.Right))
                return false;


            return true; ;
        }

        /*  A better solution is to look at each node only once. The trick is to write a utility
            helper function IsBSTUtil(BinaryTreeNode* root, int min, int max) that traverses down the tree
            keeping track of the narrowing min and max allowed values as it goes, looking at each node only
            once. The initial values for min and max should be INT_MIN and INT_MAX — they narrow
            from there.
        */
        public bool CheckBSTEfficiently(BSTNode<int> root)
        {
            return CheckBSTUtil(root, int.MinValue, int.MaxValue);
        }

        private bool CheckBSTUtil(BSTNode<int> root, int minValue, int maxValue)
        {
            if (root == null)
                return true;

            return (root.Data > minValue &&
                root.Data < maxValue &&
                CheckBSTUtil(root.Left, minValue, root.Data) &&
                CheckBSTUtil(root.Right, root.Data, maxValue));
        }


    }
}
