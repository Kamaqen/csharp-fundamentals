namespace HelloWorldConsole.Katas
{
    using System;

    public class Number
    {
        public bool IsEven(double n)
        {
            if (n % 1 != 0)
                return false;
            return n % 2 == 0;
        }
    }
}
