using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FirstStep
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment in C#
            /*
             This is a multi-line comment in C#
             It can span multiple lines.
             */
            // Shortcut for comments in C# is Ctrl + /
            //Help me please to learn C# language.
            Console.WriteLine("Hello, My name is Naresh Singh Dhami.");
            int number1 = 10;
            int number2 = 15;
            int result;
            result = number1 + number2;
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is: " + result);
            Console.ReadKey();

            // Different data types in C#
            int items = 10; // Integer type
            double price = 19.99; // Double type    
            string productName = "Widget"; // String type
            bool isAvailable = true; // Boolean type

            // Other data types in C#
            char grade = 'A'; // Character type
            float temperature = 36.6f; // Float type
            decimal balance = 1000.50m; // Decimal type
            DateTime currentDate = DateTime.Now; // DateTime type
            byte gray = 128; // Byte type and goes from -128 to 127
            long largeNumber = 1234567890L; // Long type
        }
    }
}
