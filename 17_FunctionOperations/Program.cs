using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_FunctionOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circleArea = CircleArea(4);
            Print("Area of the circle: "+circleArea);

        }
        static void Print(double value)
        {
            Console.WriteLine(value);
        }
        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static double CircleArea(double radius) => Math.PI * Math.Pow(radius, 2);
    }
}
