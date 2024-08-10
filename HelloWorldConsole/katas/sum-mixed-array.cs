namespace HelloWorldConsole.Katas
{
    using System;
    using System.Linq;

    public class SumMixedArray
    {
        public static int SumMix(object[] x)
        {
            return x.Sum(element => Convert.ToInt32(element));
        }
    }
}

// https://www.codewars.com/kata/57eaeb9578748ff92a000009/train/csharp
