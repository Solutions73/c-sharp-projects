using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = "hello";
            //string x = "hello\nworld";
            //string x = "\u0088"  //?
            //string x = "c:\windows\system\";
            //string x = "c:\\windows\\system\\";
            // verbatim string literals? no need for extra backslash by adding @ in front of str
            //string x = @"c:\windows\system\";
            //string x = @"He said "hello"";
            //string x = @"He said ""hello""";
            string x = @"He said\n""hello""";
            Console.WriteLine(x);

        }
    }
}