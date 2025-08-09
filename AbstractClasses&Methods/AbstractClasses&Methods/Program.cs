using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(20);
            Shape rectangle = new Rectangle(7, 9);

            Console.WriteLine($"The area of a circle of radius {((Circle)circle).Radius} is {circle.GetArea()}.");
            Console.WriteLine($"The area of a rectangle of width {((Rectangle)rectangle).Width} and height " +
            $"{((Rectangle)rectangle).Height} is {rectangle.GetArea()}.");
        }
    }
}
