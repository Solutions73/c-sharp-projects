using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp13
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] RandomNums = new int[100];
            byte k = 0;
            Random random = new Random();
            bool addToArray = true;

            while (k < 100)
            {
                int randomNumber = random.Next(1, 101);
                addToArray = true;
                for (int l = 0; l < k; l++)
                {
                    if (RandomNums[l] == randomNumber)
                    {
                        addToArray = false;
                        break;
                    }
                }
                if (addToArray == true)
                {
                    RandomNums[k] = randomNumber;
                    k++;
                }
            }
            Console.WriteLine(Environment.NewLine + "Length: ", RandomNums.Length + Environment.NewLine);
            foreach (int i in RandomNums)
            {
                Console.Write("{0}, " , i);
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }
    }
}
