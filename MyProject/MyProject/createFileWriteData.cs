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

            string TextToAdd = "the quick brown fox jumped over the lazy dogs.";
            StreamWriter outfile = new StreamWriter("../../newfile.txt");
            outfile.WriteLine(TextToAdd);
            outfile.Close();
        }
    }
}
