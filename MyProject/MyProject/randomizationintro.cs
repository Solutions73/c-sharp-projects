using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp12
{
    class Program
    {

        static void Main(string[] args)
        {
            //Random random = new Random();
            //string fruit;
            //int randomNumber = random.Next(0, 3);
            //switch (randomNumber)
            //{
            //    case 0:
            //        fruit = "an apple";
            //        break;
            //    case 1:
            //        fruit = "an orange";
            //        break;
            //    case 2:
            //        fruit = " a banana";
            //        break;
            //    default:
            //        fruit = "Nothing";
            //        return;
            //}
            //Console.WriteLine("I think you should have (0)", fruit);


            Random random = new Random();
            string fruit;
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 3);
                switch (randomNumber)
                {
                    case 0:
                        fruit = "an apple";
                        break;
                    case 1:
                        fruit = "an orange";
                        break;
                    case 2:
                        fruit = " a banana";
                        break;
                    default:
                        fruit = "Nothing";
                        return;
                }
                Console.WriteLine("I think you should have (0)", fruit);
            }
        }
    }
}
