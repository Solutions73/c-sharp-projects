using System;

namespace SDF2Ex1
{
    class MainClass
    {
            static void Main(string[] args)
            {
                int number;
                Console.WriteLine("Please enter a number between 1 and 10:");

                number = int.Parse(Console.ReadLine());

                if (number > 10)
                    Console.WriteLine("The number should be 10 or less!");

                if (number < 1)
                    Console.WriteLine("The number should be 1 or more!");

                if (number >= 1 && number <= 10)
                    Console.WriteLine("Entered Number is Valid");

                Console.WriteLine("Press any Key to Exit");
                Console.ReadLine();
            }
    }
}


 