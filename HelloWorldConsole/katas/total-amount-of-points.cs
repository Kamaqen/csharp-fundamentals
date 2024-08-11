namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class TotalScore
    {
        public static int TotalPoints(string[] games)
        {
            int totalScore = 0;
            string pat = @"^(\d+):(\d+)$";
            // Instantiate the regular expression object.
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            for (int i = 0; i < games.Length; i++)
            {
                Match m = r.Match(games[i]);
                Console.WriteLine(m.Groups[1]);
                int xScore = int.Parse(m.Groups[1].Value);
                int yScore = int.Parse(m.Groups[2].Value);
                if (xScore > yScore)
                {
                    totalScore += 3;
                }
                else if (xScore == yScore)
                {
                    totalScore += 1;
                }
            }

            return totalScore;
        }
    }
}
