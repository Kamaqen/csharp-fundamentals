namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestConsecutives
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            // Check for invalid inputs
            if (strarr == null || strarr.Length == 0 || k <= 0 || k > strarr.Length)
            {
                return "";
            }

            string longest = "";

            // Loop from index 0 to (strarr.Length - k)
            for (int i = 0; i <= strarr.Length - k; i++)
            {
                // Concatenate k consecutive strings starting from index i
                string concatStr = string.Concat(strarr.Skip(i).Take(k));
                // Update longest if the current concatenated string is longer
                if (concatStr.Length > longest.Length)
                {
                    longest = concatStr;
                }
            }

            return longest;
        }
    }
}

// https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp
