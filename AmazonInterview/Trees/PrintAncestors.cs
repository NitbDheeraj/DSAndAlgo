using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview.Trees
{
    public class PrintAncestors
    {
        public bool PrintAncestorsOfANode(Node root, int target)
        {
            if (root == null)
                return false;

            if (root.data == target)
                return true;

            if(PrintAncestorsOfANode(root.left, target) || PrintAncestorsOfANode(root.right, target))
            {
                Console.WriteLine(root.data);
                return true;
            }

            return false;
        }
    }
}
