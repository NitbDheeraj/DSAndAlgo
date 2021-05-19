using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class PrintCommonElementIn2List
    {

        public List<int> PrintCommonElements(Node N1, Node N2)
        {
            if (N1 == null || N2 == null)
                return null;

            List<int> data = new List<int>();

            while(N1 != null && N2 != null)
            {
                var n1 = N1.getData();
                var n2 = N2.getData();
                if (n1 == n2)
                    data.Add(N1.getData());

                if (n1 > n2)
                    N2 = N2.GetNext();

                if (n1 < n2)
                    N1 = N1.GetNext();
            }
            return data;
        }

    }
}
