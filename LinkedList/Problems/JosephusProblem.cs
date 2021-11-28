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
            //Create a circular linked list contaning all of the data
            Node p = new Node(1);
            Node q = p;

            for (int i = 2; i <= N; ++i)
            {
                Node n = new Node(i);
                p.setNext(n);
            }

            //Close the list by having the last node point to the first
            p.setNext(q);

            //Eleminate every player as long as more then one player remains
            for (int i = N; i > 1 ; --i)
            {
                for (int j = 0; j < M; j++)
                    p = p.GetNext();

                p.setNext(p.GetNext().GetNext()); //Remove the elieminated player
            }
            return p;
        }

    }
}
