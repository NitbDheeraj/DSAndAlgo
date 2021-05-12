using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class CheckIfBST
    {
        public bool CheckBST(BSTNode<int> root)
        {
            FindAnElementInBST findNode = new FindAnElementInBST();


            if (root == null)
                return true;

            if (root.Left != null && root.Data < findNode.FindMaximum(root.Left).Data)
                return false;

            if (root.Right != null &&  root.Data > findNode.FindMinimum(root.Right).Data)
                return false;

            if (!CheckBST(root.Left) || !CheckBST(root.Right))
                return false;


                return true; ;
        }

    }
}
