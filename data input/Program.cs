using System;
using System.Globalization;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the width measurement?");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the length measurement?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("How many square meters does the house have?");
            double squareMeters = double.Parse(Console.ReadLine());

            double area = width * length;
            double price = area * squareMeters;

            Console.WriteLine(area.ToString("F2"));
            Console.WriteLine(price.ToString("F2"));

            /*int intNumber = int.Parse(Console.ReadLine());
            char caracter = char.Parse(Console.ReadLine());
            double doubleNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] NameSexAgeHeight = Console.ReadLine().Split(' ');
            string name = NameSexAgeHeight[0];
            char sex = char.Parse(NameSexAgeHeight[1]);
            int age = int.Parse(NameSexAgeHeight[2]);
            double height = double.Parse(NameSexAgeHeight[3]);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(intNumber);
            Console.WriteLine(caracter);
            Console.WriteLine(doubleNumber);
            Console.WriteLine(name);
            Console.WriteLine(sex);
            Console.WriteLine(age);
            Console.WriteLine(height);*/
        }
    }
}