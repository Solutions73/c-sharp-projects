using System;

namespace fsd_csOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            fruit.Kind = "Macintosh";
            fruit.Cost = 0.5;
            string newFruit = fruit.GetFruit();
            double total = fruit.GetCost();
            Console.WriteLine("Kind of fruit: {0}", newFruit);
            Console.WriteLine("Cost per dosen: ${0}", total);
        }
        class Fruit
        {
            private string kind;
            private double cost;
            public string Kind
            {
                get { return kind; }
                set
                {
                    if (value == "Macintosh")
                    {
                        kind = "Apple";
                    }
                }
            }
            public double Cost
            {
                get { return cost; }
                set
                {
                    if (cost < 0.6)
                    {
                        cost = 0.6;
                    }
                }
            }
            public string GetFruit()
            {
                return kind;
            }
            public double GetCost()
            {
                return cost * 12;
            }
        }
    }
}
