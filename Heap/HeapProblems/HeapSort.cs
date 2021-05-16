using Heap.HeapOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.HeapProblems
{
    /*  The heap sort algorithm inserts all
        elements (from an unsorted array) into a heap, then removes them from the root of a heap until the
        heap is empty. Note that heap sort can be done in place with the array to be sorted. Instead of
        deleting an element, exchange the first element (maximum) with the last element and reduce the
        heap size (array size). Then, we heapify the first element. Continue this process until the number
        of remaining elements is one

        Time complexity: As we remove the elements from the heap, the values become sorted (since
        maximum elements are always root only). Since the time complexity of both the insertion
        algorithm and deletion algorithm is O(logn) (where n is the number of items in the heap), the time
        complexity of the heap sort algorithm is O(nlogn).
    */
    public class HeapSort
    {
        public int[] HeapSortAlgo(int[] A)
        {
            //Build a heap
            for (int i = A.Length/2 -1; i >= 0; i--)
            {
                Heapify(A,A.Length, i);
            }

            for (int i = A.Length -1; i > 0; i--)
            {
                int temp = A[A.Length - 1];
                A[A.Length - 1] = A[0];
                A[0] = temp;

                Heapify(A, i, 0);
            }

            return A;
        }

        private int[] Heapify(int[] A, int length, int i)
        {
            int l, r, max, temp;
            l = 2 * i + 1;
            r = 2 * i + 2;
            max = i;

            if (l < length && A[l] > A[max])
                max = l;

            if (r < length && A[r] > A[max])
                max = r;

            if(max != i)
            {
                temp = A[i];
                A[i] = A[max];
                A[max] = temp;

                Heapify(A,length, max);
            }

            return A;
        }

    }
}
