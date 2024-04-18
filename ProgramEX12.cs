using System;

namespace Solução_12_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de área | Academia de Programação 2024!\n");


            double comprimento = obterValor("Informe o comprimento do terreno (em metros):");
            double largura = obterValor("Agora, informe a largura do terreno (em metros):");


            double calculoArea = comprimento * largura;

            Console.WriteLine($"A área do terreno é de: {calculoArea}m²");
            if (comprimento == largura)
            {
                Console.WriteLine("Mas infelizmente o terreno não está nos padrões de venda da imobiliária.");
            }
        }
        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}