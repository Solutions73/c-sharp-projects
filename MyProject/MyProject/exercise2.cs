using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp18
{
    class Program
    {

        static void Main(string[] args)
        {
            double i = 10;
            bool result;
            if (i > 5)
            {
                result = true;
                Console.WriteLine("Greater thn 5");
            }
            else
            {
                Console.WriteLine("less than or equal to 5");
            }
            string choice = "blue";
            string carColor;
            switch (choice)
            {
                case "red":
                      carColor = "red";
                      break;
                case "blue":
                    carColor = "blue";
                    break;
                case "green":
                    carColor = "green";
                    break;
                default:
                    Console.WriteLine("We dont have this");
                    return;
                    
            }

            Console.WriteLine("{0}{1}", "We have a ", carColor);
            Random random = new Random();
            int rnd = random.Next(0, 51);
            Console.WriteLine("random number: {0}", rnd);

            Console.WriteLine("Press enetr to exit.");
            Console.ReadLine();
        }
    }
}
