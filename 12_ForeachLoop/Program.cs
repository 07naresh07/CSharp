using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using foreach loop with list of integers
            List<int> numbers = new List<int>() { 34, 12, 89, 23, 9, 12, 13, 4 };
            numbers.Sort();

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Using foreach loop with array
            string[] names = new string[5] { "Alice", "Bob", "Charlie", "Diana", "Eve" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
