using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "The quick brown fox jumped over the lazy dogs.";
            //string y = x.Substring(0, 3);  // Gets first 3 characters
            //string y = x.Substring(4, 5);  // Gets 5 characters starting at index 4
            //string y = x.Substring(4);  // Shows the whole remaining string starting at index 4
            //string y = x.Substring(4, x.Length - 10); // Start @ 4, omit last 4
            string y = "";
            /*
            try
            {
                y = x.Substring(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            */
            try
            {
                y = x.Substring(0, 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            Console.WriteLine("Substring: (0)", y);
        }
    }
}
