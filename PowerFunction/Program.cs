using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerFunction
{
    /// <summary>
    /// The problem can be recursively defined by:
    //power(x, n) = power(x, n / 2) * power(x, n / 2);        // if n is even
    // power(x, n) = x* power(x, n / 2) * power(x, n / 2);    // if n is odd

    //O(logn)
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int power(int x, int y)
        {
            int temp = 0;
            if (y == 0)
                return 1;

            temp = power(x, y / 2);

            if (y % 2 == 0)
                return temp * temp;
            else
                return x * temp * temp;
        }
    }
}
