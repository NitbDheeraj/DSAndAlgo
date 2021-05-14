using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinarySearchTrees
{
    public class FindCeiling
    {
        public int FindBSTCeiling(BSTNode<int> root, BSTNode<int> key)
        {
            return findBSTCeilingUtil(root, key, int.MinValue);

        }
        private int findBSTCeilingUtil(BSTNode<int> root, BSTNode<int> key, int prev)
        {
            if (root == null)
                return 0;

            findBSTCeilingUtil(root.Left, key, prev);

            if (root.Data == key.Data)
                return key.Data;

            if (prev < root.Data && root.Data > key.Data)
                return root.Data;

            prev = root.Data;
            return findBSTCeilingUtil(root.Right, key, prev);
        }
    }
}
