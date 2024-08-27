namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Powers
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            var powers = new List<BigInteger>();
            for (int i = 0; i <= n; i++)
            {
                var integer = BigInteger.Pow(2, i);
                powers.Add(integer);
                Console.WriteLine(powers[i]);
            }

            return powers.ToArray();
        }
    }
}
