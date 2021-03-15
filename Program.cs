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
            Console.WriteLine($"{frase.Replace("r", "l").Replace("rr", "l").Replace("R", "L").Replace("RR", "L")}");
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
