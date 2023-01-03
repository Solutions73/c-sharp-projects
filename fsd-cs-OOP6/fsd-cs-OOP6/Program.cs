using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fsd_cs_OOP6
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords c1 = new Coords();
            c1.X = 100;
            c1.Y = 500;
            Coords c2 = c1;
            Console.WriteLine(c2.X + c2.Y);

            // access modifiers
            // public - access is not restricted
            // private - access is restricted to the containing class
            // protected - access is restricted to the containing class and any class derived from the containing class
            // internal - access restricted to code in the same assembly (dll or exe)
            //protected internal - combination of protected and internal ( code in the same assembly and derived classes in 
        }
        public struct Coords
        {
            public double X, Y;
        }
    }
}
