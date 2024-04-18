namespace Solução_23_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de multiplos de tres | Academia de Programação 2024!\n");

            int soma = 0;

            for (int i = 1; i < 500; i++)
            {
                int numero = i;
                if (numero % 3 == 0)
                {
                    soma += numero;
                }
            }
            Console.WriteLine("Soma final: " + soma);

        }
    }
}