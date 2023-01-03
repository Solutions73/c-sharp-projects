using System;

namespace CS_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;
            //Console.WriteLine("Please enter a number between 1 and 10:");
            //number = int.Parse(Console.ReadLine());
            ////if (number > 10)
            ////    Console.WriteLine("The number should be 10 or less!");
            ////if(number < 1)
            ////    Console.WriteLine("The number should be 1 or more!");
            ////if(number >= 1 && number <= 10)

            //if (number < 1 || number > 10)
            //    Console.WriteLine("Entered number is invalid");
            //else
            //    Console.WriteLine("Entered number is valid");
            ////Console.WriteLine("Entered number is valid");
            //Console.WriteLine("Press any key to exit");

            //Console.ReadLine();


            int number;
            Console.WriteLine("Please enter a number between 1 and 10:");
            number = int.Parse(Console.ReadLine());

            switch (number)
            { case 1: Console.WriteLine("Entered number is one.");
                    break;
                case 2: Console.WriteLine("Entered number is two.");
                    break;
                case 3: Console.WriteLine("Entered number is three.");
                    break;
                case 4: Console.WriteLine("Entered number is four.");
                    break;
                case 5: Console.WriteLine("Entered number is five.");
                    break;
                case 6: Console.WriteLine("Entered number is six.");
                    break;
                case 7: Console.WriteLine("Entered number is seven.");
                    break;
                case 8: Console.WriteLine("Entered number is eight.");
                    break;
                case 9: Console.WriteLine("Entered number is nine.");
                    break;
                case 10: Console.WriteLine("Entered number is ten.");
                    break;
                default: Console.WriteLine("Entered number is invalid.");
                    break;
            } Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}
