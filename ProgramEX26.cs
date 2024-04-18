using System;

namespace Solução_26_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequencia Fibonacci | Academia de programação 2024!\n");

            Console.WriteLine("Digite o número de termos da sequência Fibonacci:");
            {
                int n;
                int x = 1, y = 0, z = 0;
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    z = x + y;
                    Console.WriteLine(z);
                    y = x;
                    x = z;
                }

                Console.ReadLine();
            }
        }
    }
}