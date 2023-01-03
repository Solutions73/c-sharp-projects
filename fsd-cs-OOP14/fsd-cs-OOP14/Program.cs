using System;

namespace fsd_cs_OOP14
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple Macintosh = new Apple { Amount = 12, Cost = .5 };
            Apple GrannySmith = new Apple { Amount = 12, Cost = .6 };
            int difference = Macintosh.CompareTo(GrannySmith);
            string result = "";
            if (difference == 0)
            {
                result = "the same price as";
            }
            else if (difference == 1)
            {
                result = "more expensive than";
            }
            else
            {
                result = "less expensive than";
            }
            Console.WriteLine("Macintosh apples are {0} granny Smith apples", result);
        }
    }
    class Fruit  // base class
    {
        public double Amount { get; protected set; }
        public double Cost { get; protected set; }
        public virtual void GetCost()
        {
            Console.WriteLine("Getting Cost of Fruit ...");
        }

    }
    class Apple : Fruit, IComparable  // impplement Iconparable
    {
        public double Amount { get; set; }
        public double Cost { get; set; }
        public double GetCost()
        {
            return Amount * Cost;
        }
        public int CompareTo(object fruit)
        {
            Apple toCompare = (Apple)fruit;
            double compare = this.GetCost() - toCompare.GetCost();
            if (compare == 0)
            {
                return 0;
            }
            else if (compare > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
