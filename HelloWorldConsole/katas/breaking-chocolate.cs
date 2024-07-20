namespace HelloWorldConsole.Katas
{
    public class BreakingChocolate
    {
        public static int BreakChocolate(int n, int m)
        {
            // number of breaks: n-1 * m-1
            if (n > 0 && m > 0)
            {
                var length = n - 1;
                var height = m - 1;

                return length * m + height;
            }
            return 0;
        }
    }
}
