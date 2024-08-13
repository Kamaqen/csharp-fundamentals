namespace HelloWorldConsole.Katas
{
    public class RemoveExclamation
    {
        public static string RemoveExclamationMarks(string s)
        {
            var newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() != "!")
                {
                    newString += s[i];
                }
            }
            return newString;
        }
    }
}
