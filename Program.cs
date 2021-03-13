using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string traduzir; 

            Console.WriteLine("-------------");
            Console.WriteLine("Tradutor leet");
            Console.WriteLine("-------------");
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Insira seu texto para transformalo em Leet: ");
            Console.ResetColor();
            traduzir = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("TRADUZIDO: ");
            Console.ResetColor();;
            Console.WriteLine(traduzir
            .Replace("A", "4")
            .Replace("a", "4")
            .Replace("E", "3")
            .Replace("e", "3")
            .Replace("I", "1")
            .Replace("i", "1")
            .Replace("L","1")
            .Replace("l", "1")
            .Replace("O", "0")
            .Replace("o", "0")
            .Replace("T", "7")
            .Replace("t", "7")
            .Replace("S", "5")
            .Replace("s", "5"));
            Console.WriteLine();

        
        }
    }
}
