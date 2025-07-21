using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_BreakStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<50; i++)
            {
                int square = i * i;
                Console.WriteLine(square);
                if (square>=500)
                {
                    break;
                }
            }
            int number=0;
            int squareNumber=0;
            int threshold = 333;
            for(int j=0; j<50; j++)
            {
                squareNumber = j * j;
                if (squareNumber>=threshold)
                {
                    number = j;
                    squareNumber = number * number;
                    break;
                }
            }
            Console.WriteLine($"The first number whose square is greater than or equal to {threshold} is {number}, and its square is: {squareNumber}");

            // Variable scope example
            int sum = 0;
            for(int k=0; k<10; k++)
            {
                sum += k;
            }
            Console.WriteLine($"The sum of the first 10 numbers is: {sum}");


            Console.ReadKey();

        }
    }
}
