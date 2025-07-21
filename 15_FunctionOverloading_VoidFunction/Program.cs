using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FunctionOverloading
{
    internal class Program
    {
        static double tau = 2 * Math.PI;
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 12;

            double[] nums = new double[5] {1.5, 2, 3.5, 4, 3.1};
            double sumAB = Add(a, b);
            Console.WriteLine($"Sum: {sumAB}");
            double sumABC = Add(a, b, c);
            Console.WriteLine($"Sum: {sumABC}");
            double sumNums = Add(nums);
            Console.WriteLine($"Sum of array: {sumNums}");
            Console.WriteLine();
            double radius = 1.9;
            double len = CircleLength(radius);
            Console.WriteLine($"Circle length with radius {radius} is: {len}");

            // Void function
             Greeting("Naresh");

        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Add(double a, double b, double c)
        {
            return a + b*c;
        }
        static double Add(double[] nums)
        {
            double sum = 0;
            foreach(double num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static double CircleLength(double radius)
        {
            return tau * radius;
        }

        static void Greeting(string name)
        {
            string msg = $"Hello, {name}!";
            Console.WriteLine(msg);
        }
    }
}
