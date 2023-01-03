using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProject
{
    class program
    {
        static void Main(string[] args)
        {
            Apple.Fruit fruit1 = new Apple.Fruit("Macintosh", 0.5, 12);
            string newFruit1 = fruit1.GetFruit();
            double total = fruit1.GetCost();
            Console.WriteLine("Fruit Kind: (0)", newFruit1);
            Console.WriteLine("Total Cost: $(0)(1)", total, Environment.NewLine);

            Orange.Fruit fruit2 = new Orange.Fruit("Navel", 0.75, 12);
            string newFruit2 = fruit2.GetFruit();
            double total2 = fruit2.GetCost();
            Console.WriteLine("Fruit Kind: (0)", newFruit2);
            Console.WriteLine("Total Cost: $(0)(1)", total2, Environment.NewLine);

        }
    }
}

namespace Apple
{

    class Fruit
    {
        private string fruit;
        private string kind;
        private double cost;
        private double amount;
        public Fruit(string k, double c, double a)
        {
            fruit = "Apple";
            kind = k;
            cost = c;
            amount = a;

        }
        public string GetFruit()
        {
            return fruit + " " + kind;
        }
        public double GetCost()
        {
            return cost * amount;
        }
    }
}

namespace Orange
{

    class Fruit
    {
        private string fruit;
        private string kind;
        private double cost;
        private double amount;
        public Fruit(string k, double c, double a)
        {
            fruit = "Orange";
            kind = k;
            cost = c;
            amount = a;

        }
        public string GetFruit()
        {
            return fruit + " " + kind;
        }
        public double GetCost()
        {
            return cost * amount;
        }
    }
}