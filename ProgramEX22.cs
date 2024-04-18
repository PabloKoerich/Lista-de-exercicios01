namespace Solução_22_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impressora de números impares em intervalo | Academia de Programação 2024!\n");

            for (int i = 100; i < 200; i++)
            {
                int numero = i;
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}