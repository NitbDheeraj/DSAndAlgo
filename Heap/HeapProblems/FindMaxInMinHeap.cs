using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.HeapProblems
{
    public class FindMaxInMinHeap
    {
        //Scan the leaf nodes
        public int FindMax(int[] A)
        {
            int max = 0;
            for (int i = (A.Length +1)/2; i < A.Length; i++)
            {
                if (A[i] > max)
                    max = A[i];
            }
            return max;
        }
    }
}
