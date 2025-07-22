using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person object_1 = new Person();
            object_1.name = "Naresh";
            object_1.age = 30;
            object_1.height = 5.8;
            object_1.isAlive = true;
            Console.WriteLine("Name: " + object_1.name);
            Console.WriteLine($"Age: {object_1.age}");
            Console.WriteLine($"Height: {object_1.height}");
            Console.WriteLine($"Is Alive: {object_1.isAlive}");
            Console.WriteLine();

            // Trying out with another object
            Person object_2 = new Person();
            object_2.name = "Uma";
            object_2.age = 29;
            object_2.height = 5.2;
            object_2.isAlive = true;
            Console.WriteLine("Name: " + object_2.name);
            Console.WriteLine($"Age: {object_2.age}");
            Console.WriteLine($"Height: {object_2.height}");
            Console.WriteLine($"Is Alive: {object_2.isAlive}");
            Console.WriteLine();
        }
    }

    class Person
    {
        public string name;
        public int age;
        public double height;
        public bool isAlive;
    }
}
