using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_UsingMainFunctionsArguments
{
    internal class Program
    {
        /// <summary>
        /// Making addition using console application arguments.
        /// Use main function arguments to pass numbers to the program and give values for addition using command prompt
        /// </summary>
        /// <param name="args">Parameters for addition using console command line</param>
        static void Main(string[] args)
        {
            double sum = 0;
            foreach(string arg in args)
            {
                double result = Convert.ToDouble(arg);
                sum += result;
            }
            Console.WriteLine("The sum of the arguments is: " + sum);
        }
    }
}
