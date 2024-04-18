using System;

namespace Solução_04_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de consumo de combustível | Academia de Programação 2024!\n");

            double inicio = obterValor("Digite a quilometragem inicial do veículo:");


            double fim = obterValor("Digite a quilometragem final do veículo:");


            double gasTotal = obterValor("Informe a quantidade total de combustível consumida (em litros):");


            if (inicio >= fim)
            {
                Console.WriteLine("Erro: A quilometragem inicial não pode ser maior ou igual à quilometragem final.");
            }
            else
            {
                double mediaKM = (fim - inicio) / gasTotal;
                Console.WriteLine($"O consumo médio do veículo foi de {mediaKM:F2} km/l.");
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