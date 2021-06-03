using System;

namespace fibonacciprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            int[] fibonacciseries = fibonacci.FibonacciIterative(8);//this value can be taken as input from user
            foreach (int number in fibonacciseries)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
