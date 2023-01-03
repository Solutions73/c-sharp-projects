using System;
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "A quick brown fox jumped over the lzy dogs.";
            //Console.WriteLine(x.Length);
            //int y = x.IndexOf("brown");
            //int y = x.IndexOfAny(new char[] { 'e' });
            //int y = x.IndexOfAny(new char[] { 'e', 'h' });
            int y = x.LastIndexOf("the");
            int y = x.LastIndexOfAny(new char[] { 'd' });
            Console.WriteLine(y);
        }
    }
}
