using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class FindLastModularNode
    {
        public Node FindLastModular(Node n, int k)
        {
            if (n == null)
                return null;

            int i = 0;
            Node modularNode = n;

            for (;  n != null; n.GetNext())
            {
                if (i % k == 0)
                    modularNode = n;
                i++;
            }
            return modularNode;

        }

    }
}
