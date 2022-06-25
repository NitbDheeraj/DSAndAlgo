using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class PreviousGreaterElement
    {
        public int[] previousGreater(int[] arr)
        {
            int[] pg = new int[arr.Length];

            Stack<int> s = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                while (s.Count() > 0 && s.Peek() <= arr[i])
                    s.Pop();

                if (s.Count() == 0)
                    pg[i] = -1;
                else
                    pg[i] = s.Peek();

                s.Push(arr[i]);
            }

            return pg;
        }

    }
}
