using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create an instance of the Person class
            Person obj1 = new Person();
            // Create another instance of the Person class
            Person obj2 = new Person();
            obj1.name = "Naresh";
            obj1.age = 25;
            obj1.height = 5.8;
            obj1.isMale = true;
            obj2.name = "Uma";
            obj2.age = 29;
            obj2.height = 5.2;
            obj2.isMale = false;
            // Print the details of the first person
            Console.WriteLine("Person 1 Details:");
            Console.WriteLine($"Name: {obj1.name}");
            Console.WriteLine($"Age: {obj1.age}");
            Console.WriteLine($"Height: {obj1.height}");
            Console.WriteLine($"Male: {obj1.isMale}");
            Console.WriteLine();
            // Print the details of the second person
            Console.WriteLine("Person 2 Details:");
            Console.WriteLine($"Name: {obj2.name}");
            Console.WriteLine($"Age: {obj2.age}");
            Console.WriteLine($"Height: {obj2.height}");
            Console.WriteLine($"Male: {obj2.isMale}");
            Console.WriteLine();

            // Create instances of the Person class using the constructor
            Persons ob1 = new Persons("Naresh", 1995, 5.8);
            Console.WriteLine("Person 1 Details:");
            Console.WriteLine("Name: "+obj1.name);
            Console.WriteLine("Age: "+ob1.birthYear);
            Console.WriteLine("Height "+ob1.height);
            Console.WriteLine("Male: "+ob1.isHandsomeOrBeautiful);
            Console.WriteLine();
            Persons ob2 = new Persons("Uma", 1996, 5.2);
            Console.WriteLine("Person 2 Details:");
            Console.WriteLine("Name: " + obj2.name);
            Console.WriteLine("Age: " + ob2.birthYear);
            Console.WriteLine("Height " + ob2.height);
            Console.WriteLine("Male: " + ob2.isHandsomeOrBeautiful);
            Console.WriteLine();

            // Calculate and print the age of the first person
            int age = Persons.AgeCalculator(ob1.birthYear);
            Console.WriteLine($"Age of {ob1.name} is: {age}");
            Console.WriteLine();

            // Create an instance of the Person class using the overloaded constructor
            Persons baby = new Persons("Jane");
            Console.WriteLine("Baby Details:");
            Console.WriteLine("Baby Name: " + baby.name);
            Console.WriteLine("Baby birth year: " + baby.birthYear);
            Console.WriteLine("Baby Height " + baby.height);
            Console.WriteLine("Handsome baby: " + baby.isHandsomeOrBeautiful);
            Console.WriteLine();

        }
    }
    class Persons
    {
        public string name;
        public int birthYear;
        public double height;
        public bool isHandsomeOrBeautiful;

        // Constructor to initialize the Person object
        public Persons(string name, int yearBirth, double height)
        {
            this.name = name;
            this.birthYear = yearBirth;
            this.height = height;

            // Calculate age based on the current year
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            if (age < 30 && height < 5.5)
            {
                isHandsomeOrBeautiful = false;
            }
            else
            {
                isHandsomeOrBeautiful = true;
            }
        }
        public static int AgeCalculator(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age;
        }
        // Overloaded constructor to initialize with just a name
        public Persons(string name)
        {
            this.name = name;
            this.birthYear = DateTime.Now.Year;
            this.height = 1.6;
            this.isHandsomeOrBeautiful = true;
        }
    }
    class Person
    {
        public string name;
        public int age;
        public double height;
        public bool isMale;
    }
}
