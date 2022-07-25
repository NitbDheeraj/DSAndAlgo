using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    /*
     * The idea is to consider following two possibilities for root and recursively for all nodes down the root. 
        1) Root is part of vertex cover: In this case root covers all children edges. 
            We recursively calculate size of vertex covers for left and right subtrees and add 1 to the result 
            (for root).

        2) Root is not part of vertex cover: In this case, both children of root must be included in vertex cover 
            to cover all root to children edges. 
            We recursively calculate size of vertex covers of all 
            grandchildren and number of children to the result (for two children of root).
     */
    public class VertexCoverBinaryTrees
    {
        //Basic Recursion
        public int vCoverBasic(Node root)
        {
            // The size of minimum vertex cover
            // is zero if tree is empty or there
            // is only one node
            if (root == null)
                return 0;
            if (root.left == null &&
                root.right == null)
                return 1;

            // Calculate size of vertex cover when root is part of it
            int size_incl = 1 + vCoverBasic(root.left) + vCoverBasic(root.right);

            // Calculate size of vertex cover when root is not part of it
            int size_excl = 0;
            if (root.left != null)
                size_excl += 1 + vCoverBasic(root.left.left) + vCoverBasic(root.left.right);
            if (root.right != null)
                size_excl += 1 + vCoverBasic(root.right.left) + vCoverBasic(root.right.right);

            return Math.Min(size_incl, size_excl);

        }


        public int vCoverMemonised(Vcnode root)
        {
            // The size of minimum vertex cover
            // is zero if tree is empty or there
            // is only one node
            if (root == null)
                return 0;
            if (root.left == null &&
                root.right == null)
                return 1;

            // If vertex cover for this node is
            // already evaluated, then return it
            // to save recomputation of same subproblem again.
            if (root.vc != 0)
                return root.vc;

            // Calculate size of vertex cover when root is part of it
            int size_incl = 1 + vCoverMemonised(root.left) + vCoverMemonised(root.right);

            // Calculate size of vertex cover when root is not part of it
            int size_excl = 0;
            if (root.left != null)
                size_excl += 1 + vCoverMemonised(root.left.left) + vCoverMemonised(root.left.right);
            if (root.right != null)
                size_excl += 1 + vCoverMemonised(root.right.left) + vCoverMemonised(root.right.right);

            root.vc =  Math.Min(size_incl, size_excl);

            return root.vc;

        }
    }

    public class Vcnode
    {
        public int data;
        public int vc;
        public Vcnode left, right;
    };


}
