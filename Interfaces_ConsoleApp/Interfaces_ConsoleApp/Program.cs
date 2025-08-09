using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the shape instances
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Calling Move() method for each instanace
            car.Move();
            bicycle.Move();

            Console.ReadLine();
        }
    }
}
