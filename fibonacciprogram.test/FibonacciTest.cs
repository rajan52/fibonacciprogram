using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace fibonacciprogram.test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Check_Fibonaci_Series_count()
        {
            Fibonacci fibonacci = new Fibonacci();
            int[] arr = fibonacci.FibonacciIterative(5);
            Assert.AreEqual(5, arr.Length);
        }

        [TestMethod]
        public void Check_Fibonaci_Series_Last_Value()
        {
            Fibonacci fibonacci = new Fibonacci();
            int[] arr = fibonacci.FibonacciIterative(5);
            Assert.AreEqual(3, arr[4]);
        }
        [TestMethod]
        public void Check_Fibonaci_Series_InvalidNumber()
        {
            Fibonacci fibonacci = new Fibonacci();
            int[] arr = fibonacci.FibonacciIterative(-1);
            Assert.AreEqual(null, arr);
        }
    }
}
