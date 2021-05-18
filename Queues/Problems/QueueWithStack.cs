using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues.Problems
{
    public class QueueWithStack<T>
    {
        private Stack<T> S1 = new Stack<T>();
        private Stack<T> S2 = new Stack<T>();

        public void Enqueue(T data)
        {
            S1.Push(data);
        }

        public T Dequeue()
        {
            if (S2.Count() == 0)
            {
                while (S1.Count() > 0)
                    S2.Push(S1.Pop());
            }
            return S2.Pop();
        }

    }
}
