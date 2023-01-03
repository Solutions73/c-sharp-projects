using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "The quick brown fox jumped over the lazy dogs.";
            char[] y = new char[5];
            y[0] = x[4];
            y[1] = x[5];
            y[2] = x[6];
            y[3] = x[7];
            y[4] = x[8];
            string z = new string(y);
        }
    }
}
