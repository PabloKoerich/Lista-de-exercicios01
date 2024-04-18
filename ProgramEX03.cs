using System;

namespace Solução_03_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Volume de Cilindro | Academia de Programação 2024!\n");

            Console.WriteLine("Para calcular o volume, precisamos de algumas informações. " +
                "Por favor, insira as dimensões do cilindro (raio x altura).");

            double PI = Math.PI;

            double raio = obterValor("Insira o raio do cilindro em metros: ");


            double altura = obterValor("Insira a altura do cilindro em metros: ");


            double raioQuadrado = Math.Pow(raio, 2);
            double volumeDoCilindro = PI * raioQuadrado * altura;

            Console.WriteLine($"O volume do cilindro é: {volumeDoCilindro.ToString("F")} m³");
        }
        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}