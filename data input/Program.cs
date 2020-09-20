using System;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(" ");
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            while (X != Y)
            {

                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(" ");
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}