using System;


namespace Лабораторная_работа__2.Folder
{
    class Fibonacci
    {
        private static double A = Math.Pow(5, 0.5);
        private static double B = (A + 1) / 2;
        private static double LNb = Math.Log(B);

        public static int getIndex(decimal number)
        {
            return (int)Math.Round(Math.Log((double)((decimal)Fibonacci.A * number)) / Fibonacci.LNb);
        }
        public static  decimal getNumber(int n)
        {
            return (decimal)Math.Round(Math.Pow(Fibonacci.B, n) / Fibonacci.A);
        }
        public static FibonacciNumber find(decimal number)
        {
            return new FibonacciNumber(Fibonacci.getIndex(number));
        }
    }
}
