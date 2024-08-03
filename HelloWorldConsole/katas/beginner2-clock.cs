namespace HelloWorldConsole.Katas
{
    using System;

    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            return (int)(new TimeSpan(h, m, s).TotalMilliseconds);
        }
    }
}

// https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/train/csharp
