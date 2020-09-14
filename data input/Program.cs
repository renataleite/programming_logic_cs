using System;
using System.Globalization;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int X = A + B;

            Console.WriteLine("X = " + X);
        }
    }
}