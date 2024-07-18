using System;
using System.Collections.Generic;
using System.Text;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        // Split the input string by '-' or '_'
        var words = str.Split(new char[] { '-', '_' });
        var sb = new StringBuilder(words[0]);

        // Process each word, capitalizing the first letter if not the first word
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                sb.Append(char.ToUpper(words[i][0]));
                if (words[i].Length > 1)
                {
                    sb.Append(words[i].Substring(1));
                }
            }
        }

        return sb.ToString();
    }
}
