using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = Add(5.5, 3.9);
            Console.WriteLine(result);
            string greeting = Greeting("Naresh");

            Console.WriteLine(greeting);

            Console.ReadKey();
        }
        /// <summary>
        /// Add two numbers together
        /// </summary>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        /// <returns>Returns the addition of two numbers</returns>
        static double Add(double a, double b)
        {
            return a + b;
        }

        static string Greeting(string name)
        {
            string greetings = $"Hello, {name}!";
            return greetings;
        }
    }
}
