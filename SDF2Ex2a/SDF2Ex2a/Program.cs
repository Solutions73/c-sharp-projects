using System;

namespace SDF2Ex2a
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number between 1 and 10:");

            number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 10)
                Console.WriteLine("Entered Number is invalid.");

            else
                Console.WriteLine("Entered Number is Valid");

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
