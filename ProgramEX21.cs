using System;

namespace Solução_21_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de decisão | Academia de Programação 2024!\n");

            Console.WriteLine("Digite o valor de A:");
            string aString = Console.ReadLine();
            int a = Convert.ToInt32(aString);

            Console.WriteLine("Digite o valor de B:");
            string bString = Console.ReadLine();
            int b = Convert.ToInt32(bString);

            int c;

            if (a == b)
            {
                c = a + b;
                Console.WriteLine($"Iremos somar a sua operação\nO valor é {c}");
            }
            else
            {
                c = a * b;
                Console.WriteLine($"Iremos multiplicar sua operação\nO valor é {c}");
            }
        }
    }
}