using System;
using System.Text.RegularExpressions;

namespace HelloWorldConsole.Katas
{
    public static class CountSmileyFaces
    {
        public static int CountSmileys(string[] smileys)
        {
            string pattern = @"([:;][-~]?)?[)D]";
            Regex r = new Regex(pattern);
            int matchCount = 0;

            foreach (string word in smileys)
            {
                Match m = r.Match(word);
                if (m.Success)
                    matchCount++;
            }

            return matchCount;
        }
    }
}
