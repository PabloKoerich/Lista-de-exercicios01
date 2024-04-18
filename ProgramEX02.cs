using System;

namespace Solução_02_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura | Academia de programação 2024!\n");


            double fahrenheit = obterValor("Digite a temperatura em Graus Fahrenheit para fazer a conversão:");


            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é: {celsius:F2}°C");
        }
        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}