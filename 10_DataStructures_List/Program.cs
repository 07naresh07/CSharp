using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataStructures_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for(int i=0; i<10; i++)
            {
                numbers.Add(i*10);
            }
            numbers[5] = 77;
            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Removing the element from list using remove method");
            numbers.Remove(numbers[5]);
            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Removing the element from list using removeAt method");
            numbers.RemoveAt(2);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            numbers.Clear();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
