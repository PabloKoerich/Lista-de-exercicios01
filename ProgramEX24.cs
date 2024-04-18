namespace Solução_24_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritimo de tabuada |Academia de Programação 2024!\n");

            Console.WriteLine("Digite o número que deseja para a tabuada: ");
            string xString = Console.ReadLine();
            int x = Convert.ToInt32(xString);

            for (int i = 0; i <= 10; i++)
            {
                int tabuada = x * i;
                Console.WriteLine($"Equação {x} x {i} = {tabuada}");
            }
            Console.ReadLine();
        }
    }
}