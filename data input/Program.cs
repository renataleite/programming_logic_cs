using System;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            seconds = (seconds % 3600) % 60;

            Console.WriteLine(hours + ":" + minutes + ":"+ seconds);

        }
    }
}