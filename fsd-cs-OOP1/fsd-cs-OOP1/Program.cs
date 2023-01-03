using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fsd_cs_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Apple", 0.5, 12);
            string newFruit = fruit.GetFruit();
            double total = fruit.GetCost();
            Console.WriteLine("Kind of fruit: {0}", newFruit);
            Console.WriteLine("Cost per dozed: ${0}", total);

        }
        class Fruit
        {
            private string kind;
            private double cost;
            private double amount;


            public Fruit(string k, double c, double a)
            {
                kind = k;
                cost = c;
                amount = a;
            }
            public string GetFruit()
            {
                return kind + ", Cost: $" + cost;
            }
            public double GetCost()
            {
                return cost * amount;
            }
        }
    }
}
