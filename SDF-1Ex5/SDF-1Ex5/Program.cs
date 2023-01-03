using System;

namespace SDF_1Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //from string literal and string concatenation
            string firstname, lastname;
            firstname = "John";
            lastname = "Peter";

            string fullname = firstname + " " + lastname;
            Console.WriteLine("Full Name: " + fullname);

            //by using string constructor
            char[] letters = { 'W', 'e', 'l', 'c', 'o', 'm', 'e' };
            string greetings = new string(letters);

            Console.WriteLine("Greetings: " + greetings);
            Console.WriteLine("Length of Fullname String : " + fullname.Length);
            Console.WriteLine("Length of Greetings String : " + greetings.Length);

            Console.WriteLine("Press any one key to Exit");
            Console.ReadLine();
        }
    }
}
