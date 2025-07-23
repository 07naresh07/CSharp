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

            // Call the static method SayHello
            ob1.SayHello();

            // Call the static method SayHello using the class name (Can not be called with an object)
            Persons.SayHello(ob2.name);
            Console.WriteLine();

            // Call the GetAge method
            Persons ob3 = new Persons("Himmatwala", 1934, 5.10);
            int age = ob3.GetAge();
            Console.WriteLine($"Name: {ob3.name}, and Age: {age}");

            // Call the Greeting method
            Persons persons = new Persons("Teja", 1895, 6.11);
            persons.Greeting(ob3.name);

            // Call the overloaded Greeting methods
            Persons data = new Persons("Raz", 1909, 5.45);
            data.Greeting(ob2);
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
        // Methods
        // Void method requires object to call the function
        public void SayHello()
        {
            Console.WriteLine($"Hello {this.name}!!");
        }
        // Static method can be called without an object using the class name
        // Static method belongs to the class, not to the instance
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello from the static method of Persons class {name}!");
        }
        public int GetAge()
        {
            return DateTime.Now.Year - this.birthYear;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello!! I am {this.name}. Greetings!!");
            Console.WriteLine();
        }
        public void Greeting(string names)
        {
            Console.WriteLine($"Hello {names}, I am {this.name}. Greetings!!");
            Console.WriteLine();
        }
        // Overloaded method to accept a Persons object
        public void Greeting(Persons person)
        {
            Console.WriteLine($"Hello {person.name} I am {this.name}. Warm Welcome!!");
            Console.WriteLine();
        }
    }
}
