// See https://aka.ms/new-console-template for more information
using HelloWorldConsole.Katas;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Programa de Ejemplo Completo");

            // // Tipos de datos y variables
            // int edad = 25;
            // float altura = 1.75f;
            // bool esEstudiante = true;
            // char inicial = 'A';
            // string nombre = "Juan";
            // Console.WriteLine(
            //     "Hola, Mundo!"
            //         + " "
            //         + edad
            //         + " "
            //         + altura
            //         + " "
            //         + esEstudiante
            //         + " "
            //         + inicial
            //         + " "
            //         + nombre
            // );

            // // Métodos
            // Saludar();
            // SaludarConNombre(nombre);
            // int resultado = Sumar(10, 20);
            // Console.WriteLine("Resultado de la suma: " + resultado);

            // // Estructuras de control
            // if (edad >= 18)
            // {
            //     Console.WriteLine("Eres mayor de edad.");
            // }
            // else
            // {
            //     Console.WriteLine("Eres menor de edad.");
            // }

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("Valor de i: " + i);
            // }
            Solution.Rot13("jelou");
        }

        static void Saludar()
        {
            Console.WriteLine("Hola, Mundo!");
        }

        static void SaludarConNombre(string nombre)
        {
            Console.WriteLine("Hola, " + nombre + "!");
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
