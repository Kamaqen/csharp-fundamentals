// https://www.codewars.com/kata/5552101f47fc5178b1000050/train/csharp

using System;

namespace HelloWorldConsole.Katas
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var str = Convert.ToString(n);
            var accumulator = 0;
            for (var i = 0; i < str.Length; i++)
            {
                int numericValue = str[i] - '0';
                double resultDouble = Math.Pow(numericValue, p);
                accumulator += (int)resultDouble;
                p++;
            }
            if (accumulator % n == 0)
                return accumulator / n;
            return -1;
        }
    }
}
