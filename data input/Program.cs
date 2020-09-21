using System;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int question = 1;
            while (question == 1)
            {
                double sum = 0;
                int counter = 0;
                double X = 0;

                while (X != 2 && counter < 2)
                {
                    X = double.Parse(Console.ReadLine());

                    if (X < 0 || X > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        sum += X;
                        counter += 1;
                    }
                }
                double average = sum / counter;
                Console.WriteLine("average = " + average);

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                question = int.Parse(Console.ReadLine());
                while (question != 1 && question != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    question = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}