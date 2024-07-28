using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        /* for the sake of learning, a hashset is used to make sure no duplicates of b are allowed
        while the search runs as fast as possible */
        var setOfB = new HashSet<int>(b);

        // Now LINQ is used to filter
        return a.Where(element => !setOfB.Contains(element)).ToArray();
    }
}
