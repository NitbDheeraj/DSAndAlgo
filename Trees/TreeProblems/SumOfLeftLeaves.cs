using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    public class SumOfLeftLeaves
    {
        public int SumOfLeftLeavesinBT(Node node)
        {
            int res = 0;

            if (IsLeaf(node.left))
                res += node.left.data;
            else
                res += SumOfLeftLeavesinBT(node.left);

            return res;
        }

        public bool IsLeaf(Node node)
        {
            if (node == null)
                return false;
            if (node.left == null && node.right == null)
                return true;

            return false;
        }

    }
}
