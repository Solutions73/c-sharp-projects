using System;

namespace fsd_cs_OOP9
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("Macintosh", 0.5);
            Console.WriteLine("Type: {0}, cost per dozen: {1}", apple.Kind, apple.GetCost());
        }
    }
    //class Fruit  // base class
    //{
    //    public string Kind { get; protected set; }
    //    public double Cost { get; protected set; }
    //    public Fruit(string k, double c)
    //    {
    //        Kind = k;
    //        Cost = c;
    //    }
    //    public string GetFruit()
    //    {
    //        return Kind;
    //    }
    //    public string GetCost()
    //    {
    //        return "$" + Cost * 12;
    //    }

    //abstract class Fruit  // base class
    //{
    //    public string Kind { get; protected set; }
    //    public double Cost { get; protected set; }
    //    public Fruit(string k, double c)
    //    {
    //        Kind = k;
    //        Cost = c;
    //    }
    //    public string GetFruit()
    //    {
    //        return Kind;
    //    }
    //    public string GetCost()
    //    {
    //        return "$" + Cost * 12;
    //    }


    //abstract class Apple  // base class; abstract cannot be instanciated
    //{
    //    public string Kind { get; protected set; }
    //    public double Cost { get; protected set; }
    //    abstract public string GetCost();
    //}

    //class Fruit : Apple     //derived class
    //{

    //    public Fruit(string k, double c)
    //    {
    //        Kind = k;
    //        Cost = c;
    //    }
    //    public string GetFruit()
    //    {
    //        return Kind;
    //    }
    //    public override string GetCost()
    //    {
    //        return "$" + Cost * 12;
    //    }

    abstract class Apple  // base class; abstract cannot be instanciated
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
        abstract public string GetCost();
    }

    sealed class Fruit : Apple     //derived class; sealed cannot be used for base class
    {

        public Fruit(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetFruit()
        {
            return Kind;
        }
        sealed public override string GetCost()
        {
            return "$" + Cost * 12;
        }

    }
    
}


