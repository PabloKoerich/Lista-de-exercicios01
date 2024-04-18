using System;

namespace Solução_06_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Celsius para Fahrenheit | Academia de Programação 2024!\n");

            double C = obterValor("Por favor, digite a temperatura em Celsius que deseja converter para Fahrenheit:");


            double conversor = (9.0 / 5.0) * C + 32;

            Console.WriteLine($"A temperatura convertida de Celsius para Fahrenheit é: {conversor}°F");
        }
        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}