namespace Solução_28_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz de tabuada | Academia de programação 2024!\n");
            



            int x = 10;
            int y = 10;
            Console.ForegroundColor = ConsoleColor.Black;
            int[,] tabuada = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    tabuada[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    if (i == j)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;

                    }
                    Console.Write(tabuada[i, j].ToString().PadLeft(3) + "|");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}