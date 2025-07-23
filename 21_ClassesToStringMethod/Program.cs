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
            // Create instances of the Person class using the constructor
            Persons ob1 = new Persons("Naresh", 1995, 5.8);
            Console.WriteLine("Person 1 Details:");
            Console.WriteLine("Name: " + ob1.name);
            Console.WriteLine("Age: " + ob1.birthYear);
            Console.WriteLine("Height " + ob1.height);
            Console.WriteLine("Male: " + ob1.isHandsomeOrBeautiful);
            Console.WriteLine();
            Persons ob2 = new Persons("Uma", 1996, 5.2);
            Console.WriteLine("Person 2 Details:");
            Console.WriteLine("Name: " + ob2.name);
            Console.WriteLine("Age: " + ob2.birthYear);
            Console.WriteLine("Height " + ob2.height);
            Console.WriteLine("Male: " + ob2.isHandsomeOrBeautiful);
            Console.WriteLine();

            // ToString method demonstration
            Persons ob3 = new Persons("Haku", 1999, 5.6);
            Console.WriteLine(ob3.ToString());
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
        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age;
        }

        //ToString method is a inbuilt method. So we have to override it
        public override string ToString()
        {
            string obj = $"Name: {this.name}, Age: {this.GetAge()}, Height: {this.height}, and isHandsomeOrBeaturiful: {this.isHandsomeOrBeautiful}";
            return obj;
        }
    }
}
