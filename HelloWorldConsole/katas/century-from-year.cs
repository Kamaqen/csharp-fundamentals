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
