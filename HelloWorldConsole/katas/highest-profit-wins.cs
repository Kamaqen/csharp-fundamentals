using System;
using System.Collections.Generic;
using System.Linq;

public class MinMax
{
    public static int[] minMax(int[] lst)
    {
        Array.Sort(lst);
        return new int[] { lst[0], lst.Last() };
    }
}
