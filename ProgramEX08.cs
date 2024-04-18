namespace Solução_08_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta solução foi REMOVIDA pelo Gestor!");

            Console.WriteLine("Só fiz a implementação por preguiça de abrir a calculadora");

            double tempoDeAtraso = 0.10;
            double valorHora = 0.60;
            double hora = 0;
            int dias = 365 / 2;

            double resultado = tempoDeAtraso * dias;

            double seila = resultado / valorHora;

            if (valorHora >= 0.60)
            {
                hora += 1;

            }

            Console.WriteLine($"Tempo de atraso em horas: {seila}");


        }
    }
}