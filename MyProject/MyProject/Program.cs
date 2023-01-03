using System;

namespace MyProject
{
    class Program
    {
        public class myConstructor
        {
            public myConstructor()
            {
                Console.WriteLine("Hello World!");
            }
        }
        static void Main(string[] args)
        {
            myConstructor obj = new myConstructor();
            Console.WriteLine("Hello World!");
        }
    }
}
