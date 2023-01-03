using System;
namespace MyProject
{
    class Program
    {
        class Cost
        {
            private double amount;
            private double price;
        }
        public Cost(double a, double p)
        {
            amount = a;
            price = p;
        }
        public Cost(double a)
        {
            amount = a;
            price = 0.35;
        }
        public double Calc()
        {
            return amount * price;
        }
    }
}
static void Main(string[] args)
{
    Cost eggs = new Cost(12, 0.25);
    double cost = egg.Calc();
    Console.WriteLine("Cost of 12 eggs: $(0)", cost);
    Console.WriteLine("Pres any key to exit.");
    Console.ReadLine();
 }
