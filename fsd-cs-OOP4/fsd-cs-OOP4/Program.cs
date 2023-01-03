using System;

namespace fsd_cs_OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            fruit.NewEvent += new EventHandler(newKind);
            fruit.Kind = "Apple"; //trigger the event
            fruit.Kind = "Banana";
            fruit.Kind = "Orange";
            fruit.Kind = "Cherry";


        }
        static void newKind(object newk, EventArgs e)
        {
            Fruit fruit = (Fruit)newk;
            Console.WriteLine("Fruit changed to {0}", fruit.Kind);
        }
        class Fruit
        {
            public event EventHandler NewEvent;
            private string kind;
            public string Kind
            {
                get { return kind; }
                set {
                    kind = value;
                    NewEvent(this, EventArgs.Empty);
                }
            }
        }
    }
}
