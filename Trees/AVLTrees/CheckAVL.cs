using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinarySearchTrees;

namespace Trees.AVLTrees
{
    public class CheckAVL
    {
        public bool CheckIfAVLTree(BSTNode<int> root)
        {
            if (root == null)
                return true;
            return CheckIfAVLTree(root.Left) && CheckIfAVLTree(root.Right) && Math.Abs(GetHeight(root.Left) - GetHeight(root.Right)) <= 1;
        }

        private int GetHeight(BSTNode<int> root)
        {
            int leftHeight, rightHeight;

            if (root == null)
                return 0;
            else
            {
                leftHeight = GetHeight(root.Left);
                rightHeight = GetHeight(root.Right);

                if (leftHeight > rightHeight)
                    return leftHeight + 1;
                else
                    return rightHeight + 1;
            }


        }
    }
}
