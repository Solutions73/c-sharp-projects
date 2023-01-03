using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp9
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Even numbers: ");
            evenNums(number);
            Console.WriteLine("Done!");
        }
        static void evenNums (int i)
        {
            if (i <= 1000)
            {
                Console.Write("{0} ", i);
                i += 2;
                evenNums(i);
            }
        }
    }
}
