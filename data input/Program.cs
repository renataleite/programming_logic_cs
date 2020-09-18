using System;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = "100 50 20 10 5 2 1".Split(" ");

            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            int X = N / int.Parse(numbers[0]);
            int R = N % int.Parse(numbers[0]);
            Console.WriteLine(X + " nota(s) de R$ 100,00");

            X = R / int.Parse(numbers[1]);
            R = R % int.Parse(numbers[1]);
            Console.WriteLine(X + " nota(s) de R$ 50, 00");

            X = R / int.Parse(numbers[2]);
            R = R % int.Parse(numbers[2]);
            Console.WriteLine(X + " nota(s) de R$ 20, 00");

            X = R / int.Parse(numbers[3]);
            R = R % int.Parse(numbers[3]);
            Console.WriteLine(X + " nota(s) de R$ 10, 00");

            X = R / int.Parse(numbers[4]);
            R = R % int.Parse(numbers[4]);
            Console.WriteLine(X + " nota(s) de R$ 5, 00");
            
            X = R / int.Parse(numbers[5]);
            R = R % int.Parse(numbers[5]);
            Console.WriteLine(X + " nota(s) de R$ 2, 00 ");

            X = R / int.Parse(numbers[6]);
            R = R % int.Parse(numbers[6]);
            Console.WriteLine(X + " nota(s) de R$ 1, 00");
        }
    }
}