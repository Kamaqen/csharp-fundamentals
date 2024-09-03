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
