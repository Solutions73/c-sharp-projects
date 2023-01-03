using System;

namespace SDF_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 10;
            float b = 8.57f;
            char c = 'a';

            Console.WriteLine("Integer a Value is : " + a);
            Console.WriteLine("Float b Value is : " + b);
            Console.WriteLine("Vharacter c Value is : " + c);
            Console.WriteLine("Memory Usage of Different Datatypes");
            Console.WriteLine("Size of bool :" + sizeof(bool));
            Console.WriteLine("Size of byte :" + sizeof(byte));
            Console.WriteLine("Size of char :" + sizeof(char));
            Console.WriteLine("Size of decimal :" + sizeof(decimal));
            Console.WriteLine("Size of double :" + sizeof(double));
            Console.WriteLine("Size of float :" + sizeof(float));
            Console.WriteLine("Size of int :" + sizeof(int));
            Console.WriteLine("Size of long :" + sizeof(long));
            Console.WriteLine("Size of sbyte :" + sizeof(sbyte));
            Console.WriteLine("Size of short :" + sizeof(short));
            //Console.WriteLine("Size of unit :" + sizeof(unit));
            Console.WriteLine("Size of ushort :" + sizeof(ushort));
            Console.WriteLine("Size of ulong :" + sizeof(ulong));


            // To keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

           

        }
    }
}
