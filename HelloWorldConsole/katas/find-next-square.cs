namespace HelloWorldConsole.Katas
{
    using System;

    public class FindNextSqr
    {
        public static long FindNextSquare(long num)
        {
            long sqroot = (long)Math.Sqrt(num);
            if (sqroot * sqroot != num)
                return -1;

            long nextSqrt = sqroot + 1;

            return nextSqrt * nextSqrt;
        }
    }
}

// https://www.codewars.com/kata/56269eb78ad2e4ced1000013/train/csharp
