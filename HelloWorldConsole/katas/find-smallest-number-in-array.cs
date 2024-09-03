namespace HelloWorldConsole.Katas
{
    using System;

    public class FindSmallest
    {
        public static int FindSmallestInt(int[] args)
        {
            Array.Sort(args);
            return args[0];
        }
    }
}

// https://www.codewars.com/kata/55a2d7ebe362935a210000b2/train/csharp
