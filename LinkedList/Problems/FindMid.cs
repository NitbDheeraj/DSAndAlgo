using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Problems
{
    public class FindMid
    {
        public Node FindMiddlePointInList(Node head1)
        {
            Node rabbit = head1;
            Node tortoise = head1;

            while(rabbit != null)
            {
                rabbit = rabbit.GetNext().GetNext();
                tortoise = tortoise.GetNext();
            }
            return tortoise;
        }

    }
}
