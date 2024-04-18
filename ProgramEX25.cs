using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solução_25_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo Fatorial | Academia de Programação 2024!\n");

            string aString = Console.ReadLine();
            int a = Convert.ToInt32(aString);
            int fatorial = a;

            for (int i = a - 1; i >= 1; i--)
            {
                Console.Write($"{1 + i} x ");
                fatorial = fatorial * i;
            }
            Console.WriteLine(1);
            Console.WriteLine($"\nFatorial de é {fatorial} ");
            Console.ReadLine();
        }
    }
}