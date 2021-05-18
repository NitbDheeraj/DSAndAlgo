using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Problems
{
    public class ReverseAQueue
    {
        public Queue<int> Reverse(Queue<int> q)
        {
            Stack<int> s = new Stack<int>();
            while(q.Count() > 0)
                s.Push(q.Dequeue());

            while (s.Count() > 0)
                q.Enqueue(s.Pop());

            return q;
        }
    }
}
