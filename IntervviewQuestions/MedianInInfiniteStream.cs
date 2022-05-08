using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions
{

    //Find the position where to insert a new number using binary search O(logn) and count the median in o(n);
    public class MedianInInfiniteStream
    {
        List<int> _numbers;

        public MedianInInfiniteStream()
        {
            _numbers = new List<int>();
        }

        public void AddNumber(int num)
        {
            int position = _numbers.BinarySearch(num);

            //If binary search returns -1 this means we should insert at the first position
            if(position < 0)
            {
                position = ~position; // Bitwise compliment of -1 = 0
            }

            _numbers.Insert(position, num);
        }

        public double FindMedian()
        {
            int count = _numbers.Count();
            if (count % 2 == 0) // Even number of elements
                return (double)((_numbers[count / 2 - 1] + _numbers[count / 2]) * .5);
            else // Odd numbers of element
                return (double)_numbers[count / 2];

        }

    }
}
