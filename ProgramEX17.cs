namespace LeituraDeValoresConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leitura de Valores | Academia de programação 2024!");

            Console.WriteLine("Insira o valor de A:");
            string aString = Console.ReadLine();
            double a = Convert.ToDouble(aString);

            Console.WriteLine("Insira o valor de B:");
            string bString = Console.ReadLine();
            double b = Convert.ToDouble(bString);

            Console.WriteLine("Insira o valor de C:");
            string cString = Console.ReadLine();
            double c = Convert.ToDouble(cString);

            double resultado = a + b;

            if (resultado < c)
            {
                Console.WriteLine($"Valor de C:{c} Valor da soma:{resultado}");
                Console.WriteLine("A soma dos valores A e B é menor que o valor de C.");
            }
            else if (resultado > c)
            {
                Console.WriteLine($"Valor de C:{c} Valor da soma:{resultado}");

                Console.WriteLine("A soma dos valores A e B é maior que o valor de C.");
            }
            else
            {
                Console.WriteLine($"Valor de C:{c} Valor da soma:{resultado}");

                Console.WriteLine("A soma dos valores de A e B é igual ao valor de C");
            }
        }
    }
}