namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;

    public static class ReversedSeq
    {
        public static int[] ReverseSeq(int n)
        {
            int[] integers = new Int32[n];
            for (int i = n; i > 0; i = i - 1)
            {
                integers.SetValue(i, n - i);
            }
            return integers;
        }
    }
}

// https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp
