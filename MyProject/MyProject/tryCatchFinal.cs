using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)
        {
            LoadFile();
        }
        private static void LoadFile()
        {
            StreamReader infile = null;
            try
            {
            infile = File.OpenText("../../info.text");
                Console.WriteLine(infile.ReadToEnd());
            }
            catch (FileNotFoundException notFound)
            {
                Console.WriteLine("Oops! (0)", notFound.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (infile != null)
                {
                    infile.Close();
                }
            }
        }
    }
}
