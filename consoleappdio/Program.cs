using System;

namespace consoleappdio // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroDeVezes = 10;
            for (int i = 0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bem vindo ao Curso de DotNet {i}");
            }

        }
    }
}