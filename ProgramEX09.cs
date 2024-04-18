using System;
using System.Text;

namespace Solução_09_ConsoleApp
{
    class Principal
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Média harmônica | Academia de Programação 2024!\n");
            //Console.WriteLine("Definitivamente só a média foi harmonica nisso...\n");



            int input = coletorDeMedia("Digite um valor para adicionar a média harmonica: ");


        }
        static bool decisao()
        {
            Console.WriteLine("Deseja continuar adicionando valores? (S / N)");
            string input = Console.ReadLine();


            if (input == "S" || input == "s")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int coletorDeMedia(string texto)
        {
            Console.WriteLine(texto);
            Stack<string> meuArray = new Stack<string>();

            do
            {
                meuArray.Push(Console.ReadLine());

            } while (decisao() == true);


            foreach (string number in meuArray)
            {
                int soma;
                Console.WriteLine($"Nota: {number}");
                int numbero = Convert.ToInt32(number);
                soma = numbero + numbero;


                Console.WriteLine(soma);
            }
            return coletorDeMedia("Digite um valor para adicionar a média harmonica: ");
        }

    }
}