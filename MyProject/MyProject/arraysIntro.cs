using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] sentence = new string[4] { "The", "quick", "brown", "fox" };
            foreach (string word in sentence)
            {
                Console.Write("(0) ", word);
            }
            Console.WriteLine();
            */

            string[,] names = new string[3, 2] { { "John", "Smith", }, { "Anne", "Johson", }, { "Sally", "Jones", } };
            //Console.WriteLine(names[1, 0] + " " + names[1, 1]);
            for (int j = 0; j < names.GetLength(0); j++)
            {
                int k = 0;
                Console.Write("(0) (1)", names[j, k], names[j, k + 1]);
                k++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
    }
}
