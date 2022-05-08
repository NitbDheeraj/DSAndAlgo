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


        // Time complexity is reduced t0 O(N)
        public long BottomUpFibonacci(int n)
        {
            int[] arr = new int[n];

            arr[0] = 1;
            arr[1] = 1;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n - 1];
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
