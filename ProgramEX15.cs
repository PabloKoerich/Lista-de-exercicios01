namespace conversorDeCelsiusConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura | Academia de programação 2024!\n");

            Console.WriteLine("Digite o nome de um país qualquer: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Muito bem, agora digite a temperatura que está neste país para que façamos a conversão.");

            string celsiusString = Console.ReadLine();
            double celsius = Convert.ToDouble(celsiusString);

            double conversor = (celsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em fahrenheit é: {conversor}");
        }
    }
}