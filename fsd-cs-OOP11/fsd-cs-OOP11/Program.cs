using System;

namespace fsd_cs_OOP11
{
    class Program
        // is and as type casting
    {
        static void Main(string[] args)
        {
            //Object apple = new Orange("Navel", 0.6);
            //Orange navel = (Orange)apple;
            //if (apple is Apple)
            //{
            //    Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", navel.Kind, navel.GetCost(), Environment.NewLine);
            //}
            //else
            //{
            //    Console.WriteLine("This is not an apple!");
            //}

            //Object apple = new Apple("Navel", 0.6);
            ////Orange navel = (Orange)apple;
            //if (apple is Apple)
            //{
            //    Apple navel = (Apple)apple;
            //    Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", navel.Kind, navel.GetCost(), Environment.NewLine);
            //}
            //else
            //{
            //    Console.WriteLine("This is not an apple!");
            //}

            Object apple = new Apple("Navel", 0.6);
            if (apple is Apple)
            {
                Apple navel = apple as Apple;
                Console.WriteLine("Type: {0}, cost per dozen: {1}{2}", navel.Kind, navel.GetCost(), Environment.NewLine);
            }
            else
            {
                Console.WriteLine("This is not an apple!");
            }
        }
    }
    abstract class Fruit // base class - top of hierarchy
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
        abstract public string GetCost();
    }
    class Apple : Fruit  //  derived class - an apple is a fruit
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
    class Orange : Fruit  //  derived class - an apple is a fruit
    {
        public Orange(string k, double c)
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
