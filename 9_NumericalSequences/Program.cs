using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_NumericalSequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First 10 digits
            Console.WriteLine("First 10 +ve numbers: ");
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // First 10 negative numbers
            Console.WriteLine("First 10 -ve numbers: ");
            for (int i=0; i>-10; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // First 10 square numbers
            Console.WriteLine("First 10 square numbers: ");
            int square = 0;
            for(int i=0; i<10; i++)
            {
                square = i * i;
                Console.WriteLine(square);
            }
            Console.WriteLine();

            // First 10 even numbers
            Console.WriteLine("First 10 even numbers: ");
            int evenCount = 0;
            for(int i=0; i<100; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    evenCount++;
                    if (evenCount == 10)
                        break;
                }
            }

            // Multiplication table of a number
            double num = 10;
            Console.WriteLine($"Multiplication table of {num}:");
            double result = 0;
            for (int i=1; i<=10; i++)
            {
                result = num * i;
                Console.WriteLine($"{num}*{i} = {result}");
            }
            Console.WriteLine();

            // Ascending geometric series
            Console.WriteLine("Series that expands exponentially");
            for (double i=1; i<=100; i*=1.5)
            {
                Console.WriteLine(i);
            }

            // Asymtotic geometric series
            Console.WriteLine("Series that decreases exponentially");
            for(double i = 1; i>0.00001; i*=0.5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Albebraic series
            Console.WriteLine("Algebraic series");
            string capitalAlphabet = "";
            string smallAlphabet = "";
            for (int i=0; i<26; i++)
            {
                capitalAlphabet += (char)(65 + i);
                smallAlphabet = smallAlphabet + (char)(97 + i);
            }
            Console.WriteLine($"Capital letter alphabets: {capitalAlphabet}");
            Console.WriteLine($"Small letter alphabets: {smallAlphabet}");

            // Fibonacci series
            Console.WriteLine("Fibonacci series");
            int prev1 = 1;
            int prev2 = 1;
            Console.WriteLine(prev1);
            Console.WriteLine(prev2);
            for (int i=0; i<10; i++)
            {
                int sum = prev1 + prev2;
                Console.WriteLine(sum);
                prev1 = prev2;
                prev2 = sum;
            }
            Console.WriteLine();

            // Prime numbers
            Console.WriteLine("Less than 100 prime numbers");
            for (int i=2; i<100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
