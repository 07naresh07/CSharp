using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _23_StaticMethodClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nar = new Person("Naresh", 1995, 168);
            Console.WriteLine(nar._Name);
            Console.WriteLine(nar._isAlive);
            Console.WriteLine();

            Console.WriteLine(nar);
            // Object will not be able to access the maxAgeLimit as it belongs to class using `static` method not to the objects.
            //      Console.WriteLine(obj.maxAgeLimit)
            Console.WriteLine(Person.maxAgeLimit);

            Person uma = new Person("Uma", 1996, 155);
            Console.WriteLine(uma);
            Console.WriteLine();

            // Static method for functions (Class is used to access the method not the object from class if the function is static)
            Person.AgeGap(nar, uma);

            Console.ReadKey();
        }
    }
    class Person
    {
        // Making maxAgeLimit static will now make this instance of class not the object and only class will be able to access it not the objects.
        // Following is the static property
        public static int maxAgeLimit = 100;

        public string _Name;
        public int _BirthYear;
        public double _Height;
        public bool _isAlive;
        
        //Following _maxAgeLimit belongs to the object i.e. each object will access this value and could be changed.
        //      public int _maxAgeLimit=100;

        public Person(string name, int birthYear, double height)
        {
            this._Name = name;
            this._BirthYear = birthYear;    
            this._Height = height;
            
            this._isAlive = IsAlive(this._BirthYear);
            
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year-this._BirthYear;
            }
        }
        public int AgeCalculator()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - this._BirthYear;
            return age;
        }
        public bool IsAlive(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = AgeCalculator();
            // this.maxAgeLimit will not be object as its static method and it belongs to the class not the objects
            if(birthYear<currentYear && age<Person.maxAgeLimit)
            {
                this._isAlive = true;
            }
            else
            {
                this._isAlive = false;
            }
            return this._isAlive;
        }
        public override string ToString()
        {
            string output = $"Name: {this._Name}, Age: {AgeCalculator()}, Height: {this._Height} & IsAlive: {IsAlive(this._BirthYear)}";
            return output;
        }

        // Static method of function creation
        public static void AgeGap(Person first, Person second)
        {
            int ageDifference = Math.Abs(first.Age - second.Age);
            Console.WriteLine($"Age difference is: {ageDifference}");
        }
    }
}
