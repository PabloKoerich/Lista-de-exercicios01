using System;

namespace Solução_19_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal) | Academia de Programação 2024!\n");

            Console.Write("Por favor, insira seu peso em quilogramas (kg): ");
            string pesoString = Console.ReadLine();
            double peso = Convert.ToDouble(pesoString);

            if (peso <= 0)
            {
                Console.WriteLine("Por favor, insira um valor numérico válido e positivo para o peso.");
                return;
            }

            Console.Write("Agora, insira sua altura em metros (m): ");
            string alturaString = Console.ReadLine();
            double altura = Convert.ToDouble(alturaString);

            if (altura <= 0)
            {
                Console.WriteLine("Por favor, insira um valor numérico válido e positivo para a altura.");
                return;
            }

            double imc = peso / (Math.Pow(altura, 2));

            Console.WriteLine($"Seu IMC é: {imc.ToString("F")}");

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Seu peso está normal.");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso.");
            }
            else
            {
                Console.WriteLine("Você está obeso. =/ Mas tem um rosto tão bonito.");
            }
        }
    }
}