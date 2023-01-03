using System;

namespace SDF_1Ex5b
{
    class Program
    {
        static void Main(string[] args)
        {
            // To learn about built-in string function

            string greetings = "Welcome to Practice Lab";
            string user = "Hello User";

            Console.WriteLine("C# Built-in String Functions Example ");
            Console.WriteLine("ToUpper Function Usage: " + greetings.ToUpper());
            Console.WriteLine("ToLower Function Usage : " + greetings.ToLower());
            Console.WriteLine("Contains Function Usage : " + user.Contains("Hello"));
            Console.WriteLine("Substring Function Usage : " + greetings.Substring(11));
            Console.WriteLine("Insert Function Usage : " + user.Insert(6, "Admin "));
            Console.WriteLine("Remove Function Usage : " + greetings.Remove(11));
            Console.WriteLine("Replace Function Usage : " + greetings.Replace("Welcome to", "Thanks for using"));

            Console.WriteLine("Press any Key to Exit");
            Console.ReadLine();
        }
    }
}
