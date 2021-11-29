using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class Fibonacci
    {

        //The time complextity of this algo is O(2^n). This is very slow algorithm. and is contineously repeating the same calculations
        public long RecursiveFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }


        // Time complexity is reduced ti O(N)
        public long BottomUpFibonacci(int n)
        {
            // Declare an array to
            // store Fibonacci numbers.
            // 1 extra to handle
            // case, n = 0
            int[] f = new int[n + 2];
            int i;

            /* 0th and 1st number of the
               series are 0 and 1 */
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers
                   in the series and store it */
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        private int[] fib = new int[10];

        public int fibonacci(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 1;

            if (fib[n] != 0)
                return fib[n];

            return fib[n] = fibonacci(n - 1) + fibonacci(n - 2);
        }

    }
}
