namespace HelloWorldConsole.Katas
{
    using System;
    using System.Collections.Generic;

    public class CountChars
    {
        public static Dictionary<char, int> Count(string str)
        {
            var result = new Dictionary<char, int>();
            if (str.Length > 0)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (result.ContainsKey(str[i]))
                    {
                        result[str[i]]++; // Incrementa el valor si la clave ya existe
                    }
                    else
                    {
                        result.Add(str[i], 1); // Agrega la clave con valor 1 si no existe
                    }
                }
            }
            return result;
        }
    }
}
// https://www.codewars.com/kata/52efefcbcdf57161d4000091/train/csharp
