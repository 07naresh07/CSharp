using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_MoreOfVectorOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X = 2;
            double Y = 2;
            double Z = 2;
            Vector v0 = new Vector(X, Y, Z);
            v0.X = 5;
            Vector v1 = new Vector(5, 2, 7);

            // + Operator overloading
            Vector additionOverloading = v0 + v1;
            Console.WriteLine(additionOverloading);

            // - Operator overloading
            Vector subtractOverloading = v0 - v1;
            Console.WriteLine(subtractOverloading);

            // * Operator overloading
            double multiplyOverloading = v0 * v1;
            Console.WriteLine(multiplyOverloading);
            Console.WriteLine();

            // * Operator overloading for a double and a vector
            Vector v2 = 2.5 * v0;
            Vector v3 = 0.5 * v1;
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            double dotProduct = v2 * v3;
            Console.WriteLine(dotProduct);
            Console.WriteLine();

            // Indexing vectors
            Vector v = new Vector(10, 12, 8);
            // Get value using index
            double indV = v[0];
            Console.WriteLine(indV);
            double indV1 = v[2];
            Console.WriteLine(indV1);
            // Set value
            // Throw an error if index exceeds the actual available values
            v[0] = -5;
            v[2] = 22;
            Console.WriteLine(v);

            Console.ReadLine();
        }
    }
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Vector()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        // Loading vector inside a vector
        public Vector(Vector v)
        {
            this.X = v.X;
            this.Y = v.Y;
            this.Z = v.Z;
        }

        // Indexing vectors
        public double this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return this.X;
                }
                else if (i == 1)
                {
                    return this.Y;
                }
                else if (i == 2)
                {
                    return this.Z;
                }
                else
                {
                    throw new Exception();
                }
            }
            set
            {
                if (i == 0)
                {
                    this.X = value;
                }
                else if (i == 1)
                {
                    this.Y = value;
                }
                else if(i == 2)
                {
                    this.Z = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public override string ToString()
        {
            return $"[{this.X}, {this.Y}, {this.Z}]";
        }
        
        // + Operator overloading for two vectors
        public static Vector operator + (Vector a, Vector b)
        {
            return Vector.Addition(a, b);
        }

        // - Operator overloading for two vectors
        public static Vector operator - (Vector a, Vector b)
        {
            double newX = a.X - b.Y;
            double newY = a.Y - b.Y;
            double newZ = a.Z - b.Z;
            Vector subtract = new Vector(newX, newY, newZ);
            return subtract;
        }

        // * Operator overloading for two vectors
        public static double operator * (Vector a, Vector b)
        {
            return (a.X * b.X + a.Y * b.Y + a.Z * b.Z);
        }

        // * Operator overloading for an double and a vector
        public void Scale(double factor)
        {
            this.X *= factor;
            this.Y *= factor;
            this.Z *= factor;
        }
        
        // Scaling a vector and * operator overloading
        public static Vector operator * (double a, Vector b)
        {
            // New copy of the vector is created so that value of b will not change
            Vector v = new Vector(b);
            v.Scale(a);
            return v;
        }

        // Vector addition 
        public static Vector Addition(Vector a, Vector b)
        {
            return new Vector (a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
    }
}
