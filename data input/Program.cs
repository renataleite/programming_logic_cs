using System;
using System.Globalization;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("How many rooms do you have in your house?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name, age and height (same line):");
            string[] profile = Console.ReadLine().Split();
            string nameProfile = profile[0];
            int ageProfile = int.Parse(profile[1]);
            double heightProfile = double.Parse(profile[2]);
            Console.WriteLine(name);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price);
            Console.WriteLine(nameProfile);
            Console.WriteLine(ageProfile);
            Console.WriteLine(heightProfile);

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