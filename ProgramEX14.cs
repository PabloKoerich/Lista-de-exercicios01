namespace CalculoIdadeXdias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Idade por dias | Academia de programação 2024!\n");

            Console.WriteLine("Digite seu Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, para que eu possa calcular a sua idade em dias, preciso que informe a sua idade.");

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idade = Convert.ToInt32(idadeString);

            int idadeDias = idade * 365;

            Console.WriteLine($"Você tem {idadeDias} dias de vida.");
        }
    }
}