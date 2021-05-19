using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class JosephusProblem
    {
        public Node GetJosephusPosition(int N, int M)
        {
            Node p = new Node(1);
            Node q = p;

            for (int i = 2; i <= N; ++i)
            {
                Node n = new Node(i);
                p.setNext(n);
            }

            p.setNext(q);

            for (int i = N; i > 1 ; --i)
            {
                for (int j = 0; j < M; j++)
                    p = p.GetNext();

                p.setNext(p.GetNext().GetNext());
            }
            return p;
        }

    }
}
