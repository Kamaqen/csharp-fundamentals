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

// https://www.codewars.com/kata/559590633066759614000063/train/csharp
