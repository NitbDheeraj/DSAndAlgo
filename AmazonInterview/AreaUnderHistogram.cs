using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{
    public class AreaUnderHistogram
    {
        public int MaxAreaUnderHistogram(int[] arr)
        {
            int max = 0;

            int[] preSmaller = GetPreviousSmallerElement(arr);
            int[] nextSmaller = GetNextSmallerElement(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int currArea = (nextSmaller[i] - preSmaller[i] - 1) * arr[i];
                max = Math.Max(currArea, max);
            }
            return max;
        }

        private int[] GetPreviousSmallerElement(int[] arr)
        {
            int[] ps = new int[arr.Length];

            Stack<int> s = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                while (s.Count() > 0 && arr[s.Peek()] >= arr[i])
                    s.Pop();

                if (s.Count() > 0)
                    ps[i] = -1;
                else
                    ps[i] = s.Peek();

                s.Push(i);
            }

            return ps;
        }

        private int[] GetNextSmallerElement(int[] arr)
        {
            int[] ns = new int[arr.Length];

            Stack<int> s = new Stack<int>();

            for (int i = arr.Length -1; i >= 0 ; i++)
            {
                if (s.Count() == 0 )
                {
                    s.Push(arr[i]);
                    continue;
                }

                while (s.Count() > 0 && s.Peek() > arr[i])
                {
                    s.Pop();
                    ns[i] = i;
                }

                s.Push(arr[i]);

            }
            Array.Sort(ns);

            return ns;
            
        }
    }
}
