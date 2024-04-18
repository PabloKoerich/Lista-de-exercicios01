using System;

namespace Solução_10_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de média ponderada | Academia de Programação 2024!\n");

            double nota1 = obterValor<double>("Digite a primeira nota:");
            int peso1 = obterValor<int>("Digite o peso da primeira nota:");

            double nota2 = obterValor<double>("Digite a segunda nota:");
            int peso2 = obterValor<int>("Digite o peso da segunda nota:");


            double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

            Console.WriteLine($"A média ponderada é: {mediaPonderada:F2}");
        }

        static Tipo obterValor<Tipo>(string texto)
        {

            Console.WriteLine(texto);

            string input = Console.ReadLine();

            try
            {
                return (Tipo)Convert.ChangeType(input, typeof(Tipo));
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido, tente novamente!");
                return obterValor<Tipo>(texto);
            }
        }
    }
}