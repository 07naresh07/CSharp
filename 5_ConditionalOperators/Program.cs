using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;

            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{a} is less than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is equal to {b}");
            }

            // Logical operators with boolean values
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue && isFalse);
            Console.WriteLine(isTrue || isFalse);
            Console.WriteLine(!isTrue);
            Console.WriteLine(!isFalse);

            int value = 1;
            int min = 0;
            int max = 15;
            if (value>min && value<max)
            {
                Console.WriteLine("Value is within range");
            }
            else if(value<min || value>max)
            {
                Console.WriteLine("Value is out of range");
            }
            else if(value==min || value==max)
            {
                Console.WriteLine($"{value} is at the boundary of the range [{min}, {max}]");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
