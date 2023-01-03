using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        class Apple
        {
            public double Calc(double a, double p)
            {
                return a * p;
            }

        }
        static void Main(string[] args)
        {
            Apple cost = new Apple();
            double total = cost.Calc(12, 0.25);
            Console.WriteLine("Cost of 12 apples: $(0", total);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
       