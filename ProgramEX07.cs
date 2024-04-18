using System;
using System.Reflection.Metadata;

namespace Solução_07_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de salário comissionado | Academia de Programação 2024!\n");

            double salarioBase = obterValor<double>("Por favor, insira o salário base do vendedor:");


            int vendasTotais = obterValor<int>("Por favor, insira o total de vendas do vendedor:");


            double valorProdutoVendido = obterValor<double>("Por favor, insira o valor do produto vendido:");


            double porcentagemComissao = obterValor<double>("Por favor, insira a porcentagem da comissão (%):");


            double salarioTotal = salarioBase + (vendasTotais * (valorProdutoVendido * (porcentagemComissao / 100)));

            Console.WriteLine($"O Salário total do vendedor é de: {salarioTotal:F}");

        }

        static Dinamico obterValor<Dinamico>(string texto)
        {
            Console.WriteLine(texto);


            string input = Console.ReadLine();

            try
            {
                return (Dinamico)Convert.ChangeType(input, typeof(Dinamico));
            }
            catch
            {
                Console.WriteLine("Valor inválido!");
                return obterValor<Dinamico>(texto);
            }
        }


    }
}