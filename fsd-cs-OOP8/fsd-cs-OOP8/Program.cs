using System;

namespace fsd_cs_OOP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Macintosh", 0.5);
            Console.WriteLine("Kind: {0}, cost per dozen: {1}", apple.Kind, apple.GetCost(), Environment.NewLine);
            Orange orange = new Orange("Valencia", 0.75);
            Console.WriteLine("Type: {0}, cost per dosen: {1}{2}", orange.Kind, orange.GetCost(), Environment.NewLine);
            Banana banana = new Banana("Bunch", 0.75);
            Console.WriteLine("Type: {0}, cost per dosen: {1}{2}", banana.Kind, banana.GetCost(), Environment.NewLine);
        }
    }
    class Fruit //base class
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
    }

    class Apple : Fruit   // derived class
    {
       public Apple(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
    class Orange : Fruit  //derived class
    {
        public Orange(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
    class Banana : Fruit  //derived class
    {
        public Banana(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetCost()
        {
            return "$" + Cost * 12;
        }
    }


}