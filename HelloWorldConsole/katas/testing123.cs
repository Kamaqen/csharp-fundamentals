using System;
using System.Collections.Generic;

namespace HelloWorldConsole.Katas
{
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = (i + 1) + ": " + lines[i];
            }
            return lines;
        }
    }
}
