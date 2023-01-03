using System;

namespace SDF_1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int c;
            c = a + b;

            Console.WriteLine("Addition Operator Usage a+b = " + c);
            c = a - b;
            Console.WriteLine("Subtraction Operator Usage a-b = " + c);
            c = a * b;
            Console.WriteLine("Multiplication Operator Usage a*b   = " + c);
            c = a / b;
            Console.WriteLine("Division Operator Usage a/b = " + c);
            c = a % b;
            Console.WriteLine("Modulus Division Operator Usage a%b = " + c);
            a++;
            Console.WriteLine("Increment Operator Usage a++   = " + a);
            a--;
            Console.WriteLine("Decrement Operator Usage a--  = " + a);

            Console.WriteLine("Comparison Operators!");
            Console.WriteLine("Checking a==b  :" + (a == b));
            Console.WriteLine("Checking a!=b  :" + (a != b));
            Console.WriteLine("Checking a>b  :" + (a > b));
            Console.WriteLine("Checking a<b  :" + (a < b));
            Console.WriteLine("Checking a>=b  :" + (a >= b));
            Console.WriteLine("Checking a<=b  :" + (a <= b));

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
