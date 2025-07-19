using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;    //Post increament (Assignment first, then increment)
            b = a + b * c;
            c = a >= 100 ? b : c / 10;  // Ternary operator (if a >= 100 then b else c / 10)
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            a = (int)Math.Sqrt(b * b + c * c);
            Console.WriteLine(a);

            string s = "String literal";
            char l = s[s.Length - 1];
            Console.WriteLine(l);

            int m = 8;
            int n = 3;
            int intDiv = m/n; // Integer division
            Console.WriteLine(intDiv);
            double realDiv = m / (double)n; // Division with double to get a precise result
            Console.WriteLine(realDiv);

            // Modeular division
            int mod = m%n; // Remainder of the division
            Console.WriteLine(mod);

            // Incremeant and Decrement operators
            int x = 10;
            x = x+1; // Increment
            Console.WriteLine(x);

            int y = 110;
            y++;    // Post increment
            Console.WriteLine(y);
            y--;    // Post decrement
            Console.WriteLine(y);

            // String concatenation
            string firstName = "Naresh";
            string lastName = "Dhami";
            string fullName = firstName + " " + lastName; // Concatenation using +
            Console.WriteLine(fullName);

            // String interpolation
            string interpolatedFullName = $"{firstName} {lastName}"; // Using string interpolation
            Console.WriteLine(interpolatedFullName);

            int num1 = 5;
            double num2= 5.6;
            double result = num1 + num2;
            Console.WriteLine("{0}+{1}={2}", num1, num2, result); // Works only with WriteLine method
            Console.WriteLine($"{num1}+{num2}={result}"); // String interpolation
            // OR
            string finalResult = $"{num1}*{num2} = {num1 * num2}";
            Console.WriteLine(finalResult); 

            // Airthmetic functions and Methods
            double tau = Math.PI*2; // Tau is 2 times Pi
            double sqrt = Math.Sqrt(tau);
            Console.WriteLine($"Tau: {tau} and its SQRT: {sqrt}");
            Console.WriteLine(Math.Round(sqrt, 2));
            Console.WriteLine(Math.Abs(tau));
            Console.WriteLine(Math.Max(tau, sqrt));
            Console.WriteLine(Math.Sin(tau));
            Console.WriteLine(Math.Cos(tau));

            Console.ReadKey();
        }
    }
}
