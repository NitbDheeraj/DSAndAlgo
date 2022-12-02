using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonInterview
{

    //O(NlogK)
    public class MergeNSortedArray
    {
        public List<int> MergeSortedArrays(List<List<int>> arr)
        {
            List<int> outPut = new List<int>();

            // Create a min heap with k heap nodes. Every
            // heap node has first element of an array
            List<Tuple<int, Tuple<int, int>>> heap = new List<Tuple<int, Tuple<int, int>>>();

            for (int i = 0; i < arr.Count(); i++)
                heap.Add(new Tuple<int, Tuple<int, int>>(arr[i][0], new Tuple<int, int>(i, 0)));

            heap.Sort();

            // Now one by one get the minimum element
            // from min heap and replace it with next
            // element of its array
            while(heap.Count() > 0)
            {
                Tuple<int, Tuple<int, int>> curr = heap[0];
                    
                heap.RemoveAt(0);

                //array number
                int i = curr.Item2.Item1;

                //current index in array numvber
                int j = curr.Item2.Item2;

                outPut.Add(curr.Item1);


                // The next element belongs to same array as current.
                if (j + 1 < arr[i].Count())
                {
                    heap.Add(new Tuple<int, Tuple<int, int>>(arr[i][j + 1], new Tuple<int, int>(i, j + 1)));

                    heap.Sort();
                }

            }


            return outPut;
        }


        public void TestCode()
        {
            // Change n at the top to change number
            // of elements in an array
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int>(new int[] { 2, 6, 12 }));
            arr.Add(new List<int>(new int[] { 1, 9 }));
            arr.Add(new List<int>(new int[] { 23, 34, 90, 2000 }));

            List<int> output = MergeSortedArrays(arr);

            Console.WriteLine("Merged array is ");
            foreach (int x in output)
                Console.Write(x + " ");
        }
    }
}
