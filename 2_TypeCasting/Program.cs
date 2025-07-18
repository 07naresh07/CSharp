using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Type casting in C#: Implicit Type Casting
            int number = (int) 23.95;   // Output: 23 as its decimal part is truncated and it is not same as rounding
            Console.WriteLine(number);

        // Explicit Type Casting
            double decimalNumber = 23.95;
            int number_ = Convert.ToInt32(decimalNumber);
            Console.WriteLine(number_);

            // Boolean to integer
            Console.WriteLine(Convert.ToInt32(true));

            // String to double
            double d = Convert.ToDouble("456.099");
            Console.WriteLine(d);

            string str = Convert.ToString(23);
            Console.WriteLine(str);

        // Convert things to string
            string numberAsString = 34510.ToString();
            Console.WriteLine(numberAsString);

            // Declearing variable with `var` as "implicitly typed variable"
            var a = 10;
            Console.WriteLine(a);


            Console.ReadKey();
        }
    }
}
