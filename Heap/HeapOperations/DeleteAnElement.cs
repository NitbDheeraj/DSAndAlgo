using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap.HeapOperations
{
    /*  Suppose the Heap is a Max-Heap as:
              10
            /    \
           5      3
          / \
         2   4

        The element to be deleted is root, i.e. 10.

        Process:
        The last element is 4.

        Step 1: Replace the last element with root, and delete it.
              4
            /    \
           5      3
          / 
         2   

        Step 2: Heapify root.
        Final Heap:
              5
            /    \
           4      3
          / 
         2   
    */
    public class DeleteAnElement
    {
        public void DeleteElement(int[] arr, int i)
        {
            //Get the last element
            int lastElement = arr[arr.Length - 1];

            //Replace the element to be deleted with the last element
            arr[i] = lastElement;

            //Update the size of heap

            //Heapify the array
            Heapifying h = new Heapifying();
            h.PercolateDown(arr, i);
        }
    }
}
