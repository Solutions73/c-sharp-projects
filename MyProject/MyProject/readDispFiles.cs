using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp16
{
    class Program
    {

        static void Main(string[] args)
        {
            LoadFile();
        }
        private static void LoadFile()
        {
            StreamReader inpFile = null;
            inpFile = File.OpenText("../..info.txt");
            Console.WriteLine(inpFile.ReadToEnd());

        }
    }
}
