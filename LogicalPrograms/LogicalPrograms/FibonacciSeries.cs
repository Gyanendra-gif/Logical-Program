using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static int fibonacciSeries(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return fibonacciSeries(n - 1) + fibonacciSeries(n - 2);
        }
        public void series(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", fibonacciSeries(i));
            }
        }
    }
}
