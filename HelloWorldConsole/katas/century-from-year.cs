namespace HelloWorldConsole.Katas
{
    public static class Meh
    {
        public static int СenturyFromYear(int year)
        {
            if (year > 0)
            {
                return (year - 1) / 100 + 1;
            }
            return 0;
        }
    }
}

// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/train/csharp
