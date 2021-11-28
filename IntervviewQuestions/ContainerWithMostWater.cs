using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervviewQuestions
{
    public class ContainerWithMostWater
    {
        public void TestMaxArea()
        {
            int[] a = { 1, 5, 4, 3 };
            int[] b = { 3, 1, 2, 4, 5 };

            Console.WriteLine(CalculateMaxArea(a));

            Console.WriteLine(CalculateMaxArea(b));
        }

        //Brute Force O(N2)
        public static int maxArea(int[] a)
        {

            int Area = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    Area = Math.Max(Area, Math.Min(a[i], a[j]) *(j - i));
                }
            }
            return Area;
        }

        /* Given an array of heights of lines of boundaries of the container, 
         * find the maximum water that can be stored in a container. 
         * So start with the first and last element and check the amount of water that can be contained and
         * store that container. 
         * Now the question arises is there any better boundaries or lines that can contain maximum water. 
         * So there is a clever way to find that. Initially, there are two indices the first and last index pointing 
         * to the first and the last element (which acts as boundaries of the container), 
         * if the value of first index is less than the value of last index increase the first index else decrease the last index. 
         * As the decrease in width is constant, by following the above process the optimal answer can be reached.
         */
        public int CalculateMaxArea(int[] height)
        {

            int first = 0;
            int last = height.Length - 1;
            int area = 0;

            while (first < last)
            {
                area = Math.Max(area, Math.Min(height[first], height[last]) * (last - first));

                if (height[first] < height[last])
                    first += 1;
                else
                    last -= 1;
            }

            return area;
        }
    }
}
