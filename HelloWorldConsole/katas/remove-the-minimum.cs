namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            numbers.Remove(numbers.DefaultIfEmpty().Min());
            return numbers;
        }
    }
}

// https://www.codewars.com/kata/563cf89eb4747c5fb100001b/train/csharp
