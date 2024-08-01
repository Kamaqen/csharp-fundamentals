using System.Collections.Generic;
using System.Linq;

namespace HelloWorldConsole.Katas
{
    public class HighestScoringWord
    {
        public static string High(string s)
        {
            var words = s.Split(' ');
            var scores = new List<int>();
            foreach (var word in words)
            {
                var sum = word.Where(c => char.IsLetter(c)).Select(c => (c - 'a' + 1)).Sum();
                scores.Add(sum);
            }
            var highestScore = new List<int>(scores);
            highestScore.Sort();
            var highestIndex = scores.FindIndex(score => score == highestScore.Last());
            return words[highestIndex];
        }
    }
}

// https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp
