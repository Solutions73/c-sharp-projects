using System;

namespace fsd_cs_OOP10
{
    class Program

    // type casting
    {
        static void Main(string[] args)
        {
            //Apple apple = new Apple("Macintosh", 0.5);
            //Fruit apple = new Apple("Macintosh", 0.5);
            //Apple apple = new Fruit("Macintosh", 0.5);
            Object apple = new Apple("Granny", 0.6);
            Apple granny = (Apple)apple;
            //Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", apple.Kind, apple.GetCost(), Environment
            //    .NewLine);
            Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", granny.Kind, granny.GetCost(), Environment
                .NewLine);
        }
    }
    abstract class Fruit     // base class - top of hierarchy
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
        abstract public string GetCost();
    }

    class Apple : Fruit   // derived class - apple is also a fruit
    {

        public Apple(string k, double c)
        {
            Kind = k;
            Cost = c;
        }

        public override string GetCost()
        {
            return "$" + Cost * 12;
        }
    }
}