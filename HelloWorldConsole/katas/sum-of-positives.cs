using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorldConsole.Katas
{
    public class SumOfPositives
    {
        public static int PositiveSum(int[] arr)
        {
            var sum = 0;
            var positives = arr.Where(element => element > 0);
            foreach (var element in positives)
            {
                sum += element;
            }

            return sum;
        }
    }
}

// https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp
