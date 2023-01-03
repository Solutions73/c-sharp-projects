using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            addNumber(5);
        }
        public static void addNumber(int x)
        {
            x = x + 5;
            Console.WriteLine(x);
        }
    }
        
}
