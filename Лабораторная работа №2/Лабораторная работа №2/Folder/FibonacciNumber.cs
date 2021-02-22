using System;

namespace Лабораторная_работа__2.Folder
{
    class FibonacciNumber
    {
        private byte index;
        private decimal number;
        public FibonacciNumber(int i)
        {
            if (i <= 0)
                i = 0;
            this.index = (byte)i;
            this.number = i > 0 ? Fibonacci.getNumber(i) : 0;
        }
        public int Index
        {
            get
            {
                return (int)index;
            }
        }
        public decimal Number
        {
            get
            {
                return number;
            }
        }

    }
}
