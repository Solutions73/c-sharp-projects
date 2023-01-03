using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fsd_cs_OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit { Kind = "Macintosh", Cost = 0.5, Amount = 12 };
            Console.WriteLine("Fruit: {0} {1}", Fruit.FruitType, fruit.GetFruit());
        }
        class Fruit
        {
            public static string FruitType
            {
                get { return "Apple"; }
            }
            public string Kind { get; set; }
            public double Cost { get; set; }
            public double Amount { get; set; }

            public string GetFruit()
            {
                return this.Kind + " $" + this.Cost + " each, $" + this.Amount + " per dozen";
            }
        }
    }
}
