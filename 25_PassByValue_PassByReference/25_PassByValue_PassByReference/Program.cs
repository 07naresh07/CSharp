using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_PassByValue_PassByReference
{
    /* 
Pass by Value:
    Primitive data types (e.g., int, double, float, bool) are passed by value in C#.
    This means a copy of the variable's value is passed to the method.
    Changes made inside the method do not affect the original variable.

    Structs are also passed by value by default.
    Passing a struct creates a copy, so modifying it inside the method does not change the original instance (unless explicitly passed by reference using ref or out).

Pass by Reference:
    Classes and objects are reference types in C#.
    When you pass them to a method, the reference (pointer) to the object in memory is copied.
    This means:

    You cannot change the reference itself (assign a new object) unless you use ref.

    But you can modify the object's data, and those changes will affect the original object.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person("Naresh", 30);
            Console.WriteLine(obj);
            Increase(obj);
            Console.WriteLine(obj);

            // Pass by reference (Classes and objects follow pass by reference)
            Console.WriteLine("Pass by object reference!!");
            Increase(obj);
            Console.WriteLine(obj);

            // Pass by value (Only the copy or value of the variable is passed to the function where this value is used and original value will not be affected)
            Console.WriteLine("Pass by value!!");
            int num = 30;
            Console.WriteLine(num);
            Increase(num);
            Console.WriteLine(num);

            Console.WriteLine();

            // Another instance of class Complex
            Complex obj_ = new Complex(3, -4);
            Console.WriteLine(obj_);
            // Pass by value for structs (Structs follow pass by value not by variable and original value will not change even after applying modifications)
            Increase(obj_);
            Console.WriteLine(obj_);
        }
        // static is necessary because this method is part of class. Static is used if it belongs to the class. We can create the object of class Program and then call the IncreaseAge() method using the object.
        // Passing an object by reference
        public static void Increase(Person p)
        {
            p.Age++;
        }
        // Passing by value
        public static void Increase(int num)
        {
            num++; 
        }
        // Pass by value for structs
        public static void Increase(Complex obj)
        {
            obj.Real++;
        }
    }
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name}, {this.Age}";
        }
    }

    //Defining struct
    public struct Complex
    {
        public double Real;
        public double Imaginary;

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
