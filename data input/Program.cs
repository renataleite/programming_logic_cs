using System;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(" ");
            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);
            double pi = 3.14159;

            double TRIANGLE = (A * C)/2;
            double CIRCLE = pi * Math.Pow(C, 2);
            double TRAPEZIUM = C / 2 * (A + B);
            double SQUARE = B * B;
            double RECTANGLE = A * B;

            Console.WriteLine("TRIANGLE: " + TRIANGLE.ToString("F3"));
            Console.WriteLine("CIRCLE: " + CIRCLE.ToString("F3"));
            Console.WriteLine("TRAPEZIUM: " + TRAPEZIUM.ToString("F3"));
            Console.WriteLine("SQUARE: " + SQUARE.ToString("F3"));
            Console.WriteLine("RECTANGLE: " + RECTANGLE.ToString("F3"));
        }
    }
}