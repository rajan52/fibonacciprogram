using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacciprogram
{
   public class Fibonacci
    {
        public int[] FibonacciIterative(int len)
        {
            int[] arr = null;
            int f1 = 0, f2 = 1, i;

            if (len < 1)
                return arr;
            else
            {
                arr = new int[len];
                arr[0] = f1;
            }

            for (i = 1; i < len; i++)
            {
                arr[i] = f2;
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            return arr;
        }
    }
}
