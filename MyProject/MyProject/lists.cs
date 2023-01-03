using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listed = new List<string>();
            listed.Add("This");
            listed.Add("is");
            listed.Add("a");
            listed.Add("C# list");
            //Console.WriteLine(listed.Count);
            //Console.WriteLine(listed[3]);

            //foreach (string myList in listed)
            //{
            //    Console.Write(myList + " ");
            //}
            //Console.WriteLine();

            listed.Remove("a");

            foreach (string myList in listed)
            {
                Console.Write(myList + " ");
            }
            Console.WriteLine();
        }
    }
}
