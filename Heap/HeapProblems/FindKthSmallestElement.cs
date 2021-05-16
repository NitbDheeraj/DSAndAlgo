using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.HeapProblems
{
    public class FindKthSmallestElement
    {
        //Time Complexity: O(klogn). Since we are performing deletion operation k times and each
        //deletion takes O(logn).
        public int findKthEle(int[] A, int k)
        {
            //Delete first K -1 element from the heap and return Kth element
            for (int i = 0; i < k -1; i++)
                deleteRoot(A, A.Length);

            return A[0];
        }

        // Function to delete the root from Heap 
        private int[] deleteRoot(int[] arr, int n)
        {
            // Get the last element 
            int lastElement = arr[n - 1];

            // Replace root with first element 
            arr[0] = lastElement;

            // Decrease size of heap by 1 
            n = n - 1;

            // heapify the root node 
            return Heapify(arr, n, 0);

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

                Heapify(A, length, max);
            }
            return A;

        }
    }
}
