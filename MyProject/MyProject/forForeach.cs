using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {

        static void Main(string[] args)
        {
            //for (int i = 0; i < 100; i++)
            //    {
            //    Console.WriteLine("(0)(1)", "i equals ", i);
            //    }

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine("(0)(1)", "i equals ", i);
            //}

            //for (int i = 1; i <= 100; i+=2)
            //{
            //    Console.WriteLine("(0)(1)", "i equals ", i);
            //}

            int[] counter = { 2, 4, 6, 8, 10, 13, 16, 19 ,22, 26, 30, 34 };
            foreach (int i in counter)
            {
                Console.WriteLine("(0)(1)", "i equals ", i);
            }
        }
    }
}
