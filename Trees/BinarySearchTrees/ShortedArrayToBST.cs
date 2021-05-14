using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class ShortedArrayToBST
    {
        public BSTNode<int> BuildBST(int[] A)
        {
            return BuildBSTUtil(A, 0, A.Length);
        }

        private BSTNode<int> BuildBSTUtil(int[] A, int leftIndex, int rightIndex)
        {
            BSTNode<int> newNode;

            if (leftIndex > rightIndex)
                return null;

            if(leftIndex == rightIndex)
            {
                newNode = new BSTNode<int>(leftIndex);
            }
            else
            {
                int mid = leftIndex + (rightIndex - leftIndex) / 2;
                newNode = new BSTNode<int>(A[mid]);
                newNode.SetLeft(BuildBSTUtil(A, leftIndex, mid - 1));
                newNode.SetRight(BuildBSTUtil(A, mid + 1, rightIndex));
            }

            return newNode;
        }
    }
}
