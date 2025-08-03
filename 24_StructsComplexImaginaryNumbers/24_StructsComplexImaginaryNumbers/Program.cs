using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_StructsComplexImaginaryNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex obj = new Complex(3, -2);
            Console.WriteLine(obj);
        }
    }
    // Structs are similar to classes and only difference is memory allocation
    public struct Complex
    {
        //Define properties (real and imaginery numbers)
        public double Real
        {
            get; set;
        }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"{Real} {Imaginary}i";
        }
    }
}
