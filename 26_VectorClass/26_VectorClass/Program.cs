using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_VectorClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v0 = new Vector(1, 2, 3);
            Vector v1 = new Vector(4, 5, 6);
            Console.WriteLine("Pringting original vector!!");
            Console.WriteLine(v0);
            Console.WriteLine(v1);
            // Setting new value for vector (v1)
            v1.X = 3;
            v1.Y = 4;
            v1.Z = 0;
            Console.WriteLine();
            Console.WriteLine("Printing after set values of the vector!!");
            Console.WriteLine(v1);
            Console.WriteLine();

            // Zero vector read
            Console.WriteLine("Printing zero vector");
            Vector zero = new Vector();
            Console.WriteLine(zero);

            // Vector reading another vector
            Console.WriteLine();
            Console.WriteLine("Printing another vector object inside the vector");
            Vector copyV1 = new Vector(v1);
            Console.WriteLine(copyV1);
            Console.WriteLine();


            // Length of the vector
            /*
             * Changed GetVectorLength() to private and it will not be accessible outside of the class because property `Length` is used to calculate the length
            Console.WriteLine(v0.GetVectorLength());
            Console.WriteLine(v1.GetVectorLength());
            */

            // Getting length using property
            Console.WriteLine("Calculating length of the vector!!");
            Console.WriteLine(v1.Length);
            Console.WriteLine(v0.Length);
            Console.WriteLine();

            // Reversing the vector using method
            Console.WriteLine("Reversing vector using method!!");
            v1.ReverseVector();
            Console.WriteLine(v1);

            // Revverse vector using property
            Console.WriteLine();
            Console.WriteLine("Reversing vector using property not method");
            Console.WriteLine(v0.Reverse);
            Console.WriteLine();

            // Scale the vector
            // Calculate the length of the original vector and scaled vector for comparison
            Console.WriteLine("Scaling vector and comparing before and after length!!");
            v1.ReverseVector();
            Console.WriteLine(v1);
            Console.WriteLine(v1.Length);
            v1.Scale(0.5);
            Console.WriteLine(v1);
            Console.WriteLine(v1.Length);
            Console.WriteLine();

            // Unitize vector
            Console.WriteLine("Unitize vector making its distance to be one no matter change in the vector coordinates!!");
            if (v1.UnitizeVector(v1) == true)
            {
                Console.WriteLine("Operation Successful!!");
            }
            else
            {
                Console.WriteLine("Operation failed. NaN return!!");
            }
            Console.WriteLine(v1);
            Console.WriteLine(v1.Length);
            Console.WriteLine();

            // Unitization check for zero vector
            if (zero.UnitizeVector(zero) == true)
            {
                Console.WriteLine("Operation Successful!!");
            }
            else
            {
                Console.WriteLine("Operation failed. NaN return!!");
            }
            Console.WriteLine(zero);
            Console.WriteLine();

            // Vector addition (This method will change the original vector i.e. v2 in this case
            Console.WriteLine("Adding two vectors together.");
            Vector v2 = new Vector(3, -4, 6);
            Vector v3 = new Vector(v1);
            v2.Add(v3);
            Console.WriteLine(v2);
            Console.WriteLine();

            // Vector addition using static method that will not change the original vector
            Console.WriteLine("Vector addition using static method");
            Vector v4 = new Vector(2, 1, 0);
            Vector v5 = new Vector(5, 2, 9);
            Vector addition = Vector.Addition(v1, v2);
            Console.WriteLine(addition);
            Console.WriteLine("Checking if vector  changed or not");
            Console.WriteLine(v4);
            Console.WriteLine(v5);
            Console.WriteLine();

            // Dot product of two vectors
            Console.WriteLine("Dot product of two vectors");
            double dot = Vector.DotProduct(v4, v5);
            Console.WriteLine(dot);
            Console.WriteLine();

            // Cross product of two vectors
            Vector vx = Vector.XAxis;
            Vector vy = new Vector(0, 1, 0);
            Console.WriteLine("Cross product of two vectors!!");
            Console.WriteLine(vx);
            Console.WriteLine(vy);
            Vector crossProduct = Vector.CrossProdduct(vx, vy);
            Console.WriteLine(crossProduct);
            Console.WriteLine();

            // Call the static property for x-axis and y-axis vector


            Console.ReadKey();
        }
    }
    /// <summary>
    /// Represents a 3-dimensional vector
    /// </summary>
    public class Vector
    {
        // Properties 
        public double X
        {
            get; set;
        }
        public double Y { get; set; }
        public double Z { get; set; }

        // Static property for x-axis and y-axis vector
        public static Vector XAxis
        {
            get => new Vector(1, 0, 0);
        }
        public static Vector YAxis
        {
            get => new Vector(0, 1, 0);
        }
        public static Vector ZAxis
        {
            get
            {
                return new Vector(0, 0, 1);
            }
        }

        // Define constructors
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


        // Empty vector
        public Vector()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        
        // Vector that reads another vector
        public Vector(Vector obj)
        {
            this.X = obj.X;
            this.Y = obj.Y;
            this.Z = obj.Z;
        }

        // Method for getting length of vector (Using pythagoras theorem)
        private double GetVectorLength()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
        }

        // Getting length of the vector using property (use `get` method only as setting the length of vector is not appropriate)
        public double Length
        {
            get
            {
                return this.GetVectorLength();
            }
        }
        
        // Reverse the vector using method
        public void ReverseVector()
        {
            this.X = -this.X;
            this.Y = -this.Y;
            this.Z = -this.Z;
        }

        // Reverse vector using property
        public string Reverse
        {
            get
            {
                // Calling ReverseVector for reversing or we can add different method of reversing in this property
                // ReverseVector is void type, so we can not return this function. First call it and then return function that reads the vector i.e. ToString()
                this.ReverseVector();
                return ToString();
            }
        }

        public void Scale(double factor)
        {
            this.X *= factor;
            this.Y *= factor;
            this.Z *= factor;
        }

        // Unitize Vector
        public bool UnitizeVector(Vector obj)
        {
            double length = obj.Length;
            // Dividing by zero will give NaN. So we have to check if length is less or equal to zero.
            if(length<=0)
            {
                return false;
            }
            this.X /= length;
            this.Y /= length;
            this.Z /= length;
            return true;
        }

        //Vector addition
        public void Add(Vector otherVector)
        {

            this.X += otherVector.X;
            this.Y += otherVector.Y;
            this.Z += otherVector.Z;
        }

        // Static method for vector addition
        public static Vector Addition(Vector a, Vector b)
        {
            double newX = a.X + b.X;
            double newY = a.Y + b.Y;
            double newZ = a.Z + b.Z;
            Vector c = new Vector(newX, newY, newZ);
            return c;
        }

        // Dot product of the vector
        public static double DotProduct(Vector a, Vector b)
        {
            double dot = a.X*b.X + a.Y*b.Y + a.Z*b.Z;
            return dot;
        }

        // Cross product of two vectors
        public static Vector CrossProdduct(Vector a, Vector b)
        {
            double x = a.Y* b .Z - a.Z * b.Y;
            double y = a.Z * b.X - a.X * b.Z;
            double z = a.X * b.Y - a.Y * b.X;
            Vector crossProduct = new Vector(x, y, z);
            return crossProduct;
        }

        // Override
        public override string ToString()
        {
            return $"[{this.X}, {this.Y}, {this.Z}]";
        }
    }
}
