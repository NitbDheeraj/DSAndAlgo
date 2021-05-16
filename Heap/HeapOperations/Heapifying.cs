using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class Heapifying
    {
        //Heapifying the element at location i
        public int[] PercolateDown(int[] arr, int i)
        {
            int n = arr.Length;
            int l, r, max, temp;
            l = 2 * i + 1;
            r = 2 * i + 2;

            if (l < n && arr[l] > arr[i])
                max = l;
            else
                max = i;

            if (r < n && arr[r] > arr[max])
                max = r;

            if(max != i)
            {
                temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;

                PercolateDown(arr, max);
            }

            return arr;

        }

        

    }
}
