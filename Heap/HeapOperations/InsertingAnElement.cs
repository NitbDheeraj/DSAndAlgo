using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.HeapOperations
{
    public class InsertingAnElement
    {

        public int[] PercolateUp(int[] arr, int data)
        {
            var newArr = ResizeHeap(arr, 1);
            int i = newArr.Length - 1;
            newArr[i] = data;
            while (i >= 0 && data > newArr[(i -1)/2])
            {
                var temp = newArr[(i - 1) / 2];
                newArr[(i - 1) / 2] = newArr[i];
                newArr[i] = temp;
                i = (i - 1) / 2;
            }  
            return newArr;
        }

        public int[] ResizeHeap(int[] arr, int count)
        {
            int newArrlength = arr.Length + count;

            int[] newArr = new int[newArrlength];

            for (int i = 0; i < arr.Length; i++)
                newArr[i] = arr[i];

            return newArr;
        }
    } 
}
