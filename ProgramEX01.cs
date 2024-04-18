using System;

namespace Solução_01_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Volume | Academia de Programação 2024!\n");

            Console.WriteLine("Para calcular o volume, precisamos de algumas informações. " +
                "Por favor, insira as dimensões do objeto (comprimento x largura x altura).");

            double unidadeDeMedida = obterValor("Insira a unidade de medida (por exemplo, cm, m, etc.): ");
            double comprimento = obterValor("Insira o comprimento: ");
            double largura = obterValor("Insira a largura: ");
            double altura = obterValor("Insira a altura: ");
            double calcVolume = comprimento * largura * altura;


            Console.WriteLine($"O volume do objeto é de {calcVolume.ToString("F")} {unidadeDeMedida}³");

        }

        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;

        }
    }
}