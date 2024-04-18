using System;

namespace Solução_18_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = obterValor("Digite o primeiro número:");
            int numero2 = obterValor("Digite o segundo número:");
            int numero3 = obterValor("Digite o terceiro número:");

            ordenaValores(numero1, numero2, numero3);
        }

        static void ordenaValores(int numero1, int numero2, int numero3)
        {
            int[] numeros = { numero1, numero2, numero3 };

            Array.Sort(numeros);

            Console.WriteLine("Números ordenados:");
            foreach (int numero in numeros)
            {
                Array.Reverse(numeros);
                Console.WriteLine(numero);
            }
        }

        static int obterValor(string texto)
        {
            Console.WriteLine(texto);

            int input = Convert.ToInt32(Console.ReadLine());

            return input;
        }
    }
}