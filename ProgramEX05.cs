using System;

namespace Solução_05_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Volume de Esfera | Academia de Programação 2024!\n");

            Console.WriteLine("Para calcular o volume de uma esfera, precisamos que você informe o raio da esfera.");

            double raio = obterValor("Digite o valor do raio: ");

            double raioCubico = Math.Pow(raio, 3);
            double PI = Math.PI;

            double calculoVolume = (4.0 / 3.0) * PI * raioCubico;

            Console.WriteLine($"O volume da esfera é: {calculoVolume.ToString("F")} unidades cúbicas.");
        }

        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}