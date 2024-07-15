namespace HelloWorldConsole.Katas
{
    public static class Multiples
    {
        public static int Solution(int value)
        {
            List<int> multiples = new List<int>();
            var sum = 0;
            for (var i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }
            foreach (var num in multiples)
            {
                sum += num;
            }
            return sum;
        }
    }
}
