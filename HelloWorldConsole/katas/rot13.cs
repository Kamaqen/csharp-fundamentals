namespace HelloWorldConsole.Katas
{
    public class Solution
    {
        public static char Rot13(string message)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('A' + i);
            }
            Console.WriteLine((char)(alphabet[2] + 13));
            return (char)(alphabet[2] + 13);
        }
    }
}
