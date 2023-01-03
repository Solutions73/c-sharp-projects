using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            checkColor("yellow");
        }
        public static void checkColor(string choice)
        {
            string carColor;

            switch(choice)
            {
                case "red":
                    carColor = "red car";
                    break;

                case "blue":
                    carColor = "blue car";
                    break;

                case "yello":
                    carColor = "yellow car";
                    break;

                default:
                    Console.WriteLine("Sorry, we don't have this color");
                    return;
            }
            Console.WriteLine("{0}{1}", "We have a ", carColor);
            */


        checkColor("yellow");
        }
        public static void checkColor(string choice)
        {
            string carColor;

            switch (choice)
            {
                case "red":
                case "blue":                   
                case "yellow":
                    carColor = "We have this car!";
                    break;

                default:
                    Console.WriteLine("Sorry, we don't have this color");
                    return;
            }
            Console.WriteLine(carColor);

        }
    }
}