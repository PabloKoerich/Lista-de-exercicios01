namespace PadariaHotpão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padaria Hotpão | Academia de programação 2024!\n");

            Console.WriteLine("Quantidade de pães vendidos no dia: ");

            string paesString = Console.ReadLine();
            double paes = Convert.ToDouble(paesString);
            double calculoPaes = paes * 0.12;

            Console.WriteLine("Valor arrecadado com pães foi: " + calculoPaes);

            Console.WriteLine("Quantidade de Broa vendidos no dia: ");
            string broaString = Console.ReadLine();
            double broa = Convert.ToDouble(broaString);
            double calculoBroa = broa * 1.5;

            Console.WriteLine("Valor arrecadado com Broas foi: " + calculoBroa);

            double arrecadacao = calculoBroa + calculoPaes;

            Console.WriteLine("Arrecadação do dia foi: " + arrecadacao.ToString("F"));

            double poupanca = arrecadacao * 0.1;

            Console.WriteLine("Valor direcionado para a poupança é: " + poupanca.ToString("F"));
        }
    }
}