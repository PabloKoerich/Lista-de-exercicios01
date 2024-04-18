namespace Solução_16_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Dedução | Academia de programação 2024!");

            double salarioAtual = obterValor("(\"Informe o salário atual do funcionário:\");");

            double aumentoSalarial = salarioAtual * 1.15;
            double impostoSalario = aumentoSalarial * .92;

            Console.WriteLine($"O salário inicial é: {salarioAtual.ToString("F")}\nO salário com aumento é: {aumentoSalarial.ToString("F")}\n" +
                $"O salário com impostos é: {impostoSalario.ToString("F")}");

        }

        static double obterValor(string texto)
        {
            Console.WriteLine(texto);

            double input = Convert.ToDouble(Console.ReadLine());

            return input;
        }
    }
}