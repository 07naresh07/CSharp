using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user input for two numbers
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter second numner: ");
            string num2 = Console.ReadLine();

            // Convert input to integers
            double val1=0;
            double val2=0;
            try
            {
                val1 = Convert.ToDouble(num1);
                val2 = Convert.ToDouble(num2);
            }
            catch
            {
                Console.WriteLine("Wrong input, please enter valid numbers.");
                Console.WriteLine("Enter any key to exit.");
                Console.ReadKey();
                return;
            }
            string add = $"{val1}+{val2} = {val1+val2}";
            string substract = $"{val1}-{val2} = {val1-val2}";
            string multiply = $"{val1}*{val2} = {val1*val2}";
            string divide = $"{val1}/{val2} = {val1/val2}";
            string modulo = $"{val1}%{val2} = {val1%val2}";
            string power = $"{val1}^{val2} = {Math.Pow(val1, val2)}";
            string squareRoot1 = $"√{val1} = {Math.Sqrt(val1)}";
            string squareRoot2 = $"√{val2} = {Math.Sqrt(val2)}";
            Console.WriteLine(add);
            Console.WriteLine(substract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.WriteLine(modulo);
            Console.WriteLine(power);
            Console.WriteLine(squareRoot1);
            Console.WriteLine(squareRoot2);

            Console.WriteLine("Enter any key to exit.");
            Console.ReadKey();
        }
    }
}
