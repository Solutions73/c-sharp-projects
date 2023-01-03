using System;

namespace fsd_cs_OOP12
{
    class Program

        // polymorphism
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit();
            f1.GetCost();
            Fruit f2 = new Apple(0.5);
            f2.GetCost();
            Fruit f3 = new Orange(0.6);
            f3.GetCost();
            Fruit f4 = new Banana(0.25);
            f4.GetCost();
        }
    }
    class Fruit // base class
    {
        public double Cost { get; protected set; }
        public virtual void GetCost()   //virtual lets derived classes override the method
        {
            Console.WriteLine("Getting Cost of Fruit ...");
        }
    }
    class Apple : Fruit //derived class - apple is a fruit
    {
        public Apple(double c)

        {
            Cost = c;
        }
        public override void GetCost()
        {
            Console.WriteLine("Apple are ${0} a dozen", Cost * 12);
        }
    }
    class Orange : Fruit  //derived class - orange is a fruit
    {
        public Orange(double c)

        {
            Cost = c;
        }
        public override void GetCost()
        {
            Console.WriteLine("Orange are ${0} a dozen", Cost * 12);
        }
    }
    class Banana : Fruit  //derived class - orange is a fruit
    {
        public Banana(double c)

        {
            Cost = c;
        }
        public override void GetCost()
        {
            Console.WriteLine("Banana are ${0} a dozen", Cost * 12);
        }
    }

}
