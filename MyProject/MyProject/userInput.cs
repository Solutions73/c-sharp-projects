using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer: ");
            string input = Console.ReadLine();  // read string from console.
            Console.WriteLine("You typed (0)", input);
            int num;
            if (int.TryParse(input, out num)); //try to parse the string as integer
            {
                Console.Write("Multiply by 1000: ");
                Console.WriteLine(num * 1000);
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
        }
    }
}
