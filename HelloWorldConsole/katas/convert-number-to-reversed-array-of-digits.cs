namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;

    namespace Solution
    {
        class Digitizer
        {
            public static long[] Digitize(long n)
            {
                var nStringReversed = n.ToString().Reverse();
                var nList = new List<long>();
                foreach (char element in nStringReversed)
                {
                    long number = element - '0';
                    nList.Add(number);
                }
                return nList.ToArray();
            }
        }
    }
}

// https://www.codewars.com/kata/5583090cbe83f4fd8c000051/train/csharp
