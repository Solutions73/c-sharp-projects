using System;

namespace fsd_cs_OOP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("Macintosh", 0.5);
            Console.WriteLine("Kind: {0}, cost per dozen: {1}", apple.Kind, apple.GetCost());
        }
    }
    class Apple  //base class
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
    }
    class Fruit : Apple  // derived class
    {
        public Fruit(string k, double c)
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
