namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;

    public class TakeAWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            int nCount = Array.FindAll<string>(walk, x => x == "n").Length;
            int sCount = Array.FindAll<string>(walk, x => x == "s").Length;
            int eCount = Array.FindAll<string>(walk, x => x == "e").Length;
            int wCount = Array.FindAll<string>(walk, x => x == "w").Length;

            if (walk.Length == 10 && nCount == sCount && eCount == wCount)
                return true;
            return false;
        }
    }
}
