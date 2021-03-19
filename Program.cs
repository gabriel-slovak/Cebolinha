using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase; 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------");
            Console.WriteLine("Cebolinha");
            Console.WriteLine("----------");
            Console.ResetColor();

            Console.WriteLine();
            Console.Write("Digite uma frase que tenha 'R': ");
            frase = Console.ReadLine();
            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{frase.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("r","l").Replace("R","L")}");
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
