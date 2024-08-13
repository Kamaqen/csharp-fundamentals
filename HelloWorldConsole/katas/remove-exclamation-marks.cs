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

// https://www.codewars.com/kata/57a0885cbb9944e24c00008e/train/csharp
