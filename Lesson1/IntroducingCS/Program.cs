using System;

namespace IntroducingCS
{
    class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
    }
// 2. Modify the Rectangle class as shown below:
class Rectangle : Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Width * Length;
        }
    }
// 3. Now, modify the code of the Main method as shown below:
static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 20);
        Console.WriteLine(
        “Width ={ 0}, Length ={ 1}, Area = { 2}”, rect.Width, rect.Length, rect.GetArea());
    }
}
