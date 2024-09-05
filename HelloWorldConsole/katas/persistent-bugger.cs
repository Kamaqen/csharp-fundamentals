namespace HelloWorldConsole.Katas
{
    using System;

    public class Persist
    {
        public static int Persistence(long n)
        {
            int persistence = 0;
            string ene = n.ToString();
            while (ene.Length > 1)
            {
                int producto = 1;
                for (int i = 0; i < ene.Length; i++)
                {
                    int cifraParsed = (int)Char.GetNumericValue(ene[i]);
                    producto = producto * cifraParsed;
                }
                ene = producto.ToString();
                persistence++;
            }

            return persistence;
        }
    }
}

// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp
