using System;

namespace FSD_cs_Lab2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, c;

            Console.WriteLine("Enter Temoperature in Fahrenheit");
            f = int.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine("Temoperature in Celsius is: " + c);
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

    }
}
