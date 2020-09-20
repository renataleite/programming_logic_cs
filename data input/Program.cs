using System;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
           
            if (age < 0)
            {
                Console.WriteLine("Impossível de calcular");
            }
            else
            {
                while (age >= 0)
                {
                    sum += age;
                    counter += 1;

                    age = int.Parse(Console.ReadLine());
                }
                double average = (double)sum / counter;
                Console.WriteLine(average.ToString("F2"));
            }
        }
    }
}