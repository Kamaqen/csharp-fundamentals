using System;
using System.Collections.Generic;

namespace HelloWorldConsole.Katas
{
    public static class GreedIsGood
    {
        public static int Score(int[] dice)
        {
            var counts = new Dictionary<int, int>();
            foreach (var die in dice)
            {
                if (counts.ContainsKey(die))
                {
                    counts[die]++;
                }
                else
                {
                    counts[die] = 1;
                }
            }

            int total = 0;

            foreach (var kvp in counts)
            {
                int value = kvp.Key;
                int count = kvp.Value;

                if (value == 1)
                {
                    total += (count >= 3 ? 1000 : 0) + (count % 3) * 100;
                }
                else if (value == 5)
                {
                    total += (count >= 3 ? 500 : 0) + (count % 3) * 50;
                }
                else if (count >= 3)
                {
                    total += value * 100;
                }
            }

            return total;
        }
    }
}

// https://www.codewars.com/kata/5270d0d18625160ada0000e4/train/csharp
