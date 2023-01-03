using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = "10";
            //string y = "20";
            //string z = x + y; // just adds strings
            //Console.WriteLine(x + " + " + y + " = " + z);

            //string x = "10";
            //string y = "20";
            //int x1 = int.Parse(x);
            //int y1 = int.Parse(y);

            //int z = x1 + y1; // just adds strings
            //Console.WriteLine(x + " + " + y + " = " + z);

            //string x = "10";
            //string y = "20";
            //int x1;
            //int y1;
            //int.TryParse(x, out x1);
            //int.TryParse(y, out y1);
            //int z = x1 + y1; // just adds strings
            //Console.WriteLine(x + " + " + y + " = " + z);

            //string x = "10a";
            //string y = "20";
            //int x1;
            //int y1;
            //int.TryParse(x, out x1);
            //int.TryParse(y, out y1);
            //int z = x1 + y1; // just adds strings
            //Console.WriteLine(x + " + " + y + " = " + z);

            string x = "10";
            string y = "20";
            int x1 = Convert.ToInt32(x);
            int y1 = Convert.ToInt32(y);

            int z = x1 + y1; // just adds strings
            Console.WriteLine(x + " + " + y + " = " + z);


        }
    }
}
