using System.Text;

namespace HelloWorldConsole.Katas
{
    public class Solution
    {
        public static string Rot13(string message)
        {
            var encodedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char rotatedChar = (char)(((c - offset + 13) % 26) + offset);
                    encodedMessage.Append(rotatedChar);
                }
                else
                {
                    // If it's not a letter, just append the character as is.
                    encodedMessage.Append(c);
                }
            }

            Console.WriteLine(encodedMessage.ToString());

            return encodedMessage.ToString();
        }
    }
}
