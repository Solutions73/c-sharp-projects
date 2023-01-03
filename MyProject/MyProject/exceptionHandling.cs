using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int i = 1 / int.Parse("0");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
