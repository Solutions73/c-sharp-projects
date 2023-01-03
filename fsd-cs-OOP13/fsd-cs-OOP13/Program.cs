using System;

namespace fsd_cs_OOP13
{
    class Program
    {
        // override and NEW
        static void Main(string[] args)
        {
            Apple apple = new Apple(0.5);  // invoking directly on the derived class
            apple.GetCost();
            Fruit fruit = apple;  // invoking on derived class cast as base class
            fruit.GetCost();
        }
    }
    class Fruit   // base class
    {
        public double Cost { get; protected set; }
        public virtual void GetCost()
        {
            Console.WriteLine("Getting Cost of Fruit...");
        }
    }
    class Apple : Fruit  // derived class - apple is a fruit
    {
        public Apple(double c)
        {
            Cost = c;
        }
        //public new void GetCost()
        //{
        //    Console.WriteLine("Apple are ${0} a dozen", Cost * 12);
        //}
        public override void GetCost()
        {
            Console.WriteLine("Apple are ${0} a dozen", Cost * 12);
        }
    }
}
