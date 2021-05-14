using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    // The idea behind this solution is that, inorder traversal of BST produces sorted lists.
    // While traversing the BST in inorder, keep track of the number of elements visited
    public class FindKthSmallestElement
    {
        public BSTNode<int> findElement(BSTNode<int> root, int k)
        {
            return findElementUtil(root, k, 1);

        }

        private BSTNode<int> findElementUtil(BSTNode<int> root, int k, int count)
        {
            if (root == null)
                return null;

            BSTNode<int> left = findElementUtil(root.Left, k, count);
            if (left != null)
                return left;
            if (count == k)
                return root;
            count++;
            return findElementUtil(root.Right, k, count);

        }
    }
}
