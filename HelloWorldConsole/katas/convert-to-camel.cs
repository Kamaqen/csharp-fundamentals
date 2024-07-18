using System.Text;

namespace HelloWorldConsole.Katas
{
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
}

// https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
