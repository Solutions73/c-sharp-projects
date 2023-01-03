using System;

namespace SDF2Ex2b
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number between 1 and 10:");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Entered number is One.");
                    break;

                case 2:
                    Console.WriteLine("Entered number is Two.");
                    break;

                case 3:
                    Console.WriteLine("Entered number is Three.");
                    break;

                case 4:
                    Console.WriteLine("Entered number is Four.");
                    break;

                case 5:
                    Console.WriteLine("Entered number is Five.");
                    break;

                case 6:
                    Console.WriteLine("Entered number is Six.");
                    break;

                case 7:
                    Console.WriteLine("Entered number is Seven.");
                    break;

                case 8:
                    Console.WriteLine("Entered number is Eight.");
                    break;

                case 9:
                    Console.WriteLine("Entered number is Nine.");
                    break;

                case 10:
                    Console.WriteLine("Entered number is Ten.");
                    break;

                default:
                    Console.WriteLine("Entered number is invalid.");
                    break;
            }
            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
