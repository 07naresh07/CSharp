using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ClassesAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ob1 = new Person("Naresh", "Dhami", 1995, 168);
            Console.WriteLine(ob1);
            Console.WriteLine(ob1.FirstName);
            ob1.FirstName = "Adrift";
            Console.WriteLine(ob1.FirstName);
            Console.WriteLine();

            // Printing and setting last name
            Console.WriteLine();
            Console.WriteLine(ob1.LastName);
            ob1.LastName = "Raptor";
            Console.WriteLine(ob1.LastName);
            Console.WriteLine();

            // Accessing the other properties
            Console.WriteLine(ob1.IsAlive);
            Console.WriteLine(ob1.Age);

        }
    }

    class Person
    {
        private string _firstName;
        private string _lastName;
        private int _birthYear;
        private double _height;
        private bool _isAlive;
        
        // Properties to access private fields
        public string FirstName
        {
            // get method to access the private fields from outside of the class
            get
            {
                return _firstName;
            }
            // set method to modify the private fields from outside of the class
            // value is the keyword that represents the value being assigned to the property
            set
            {
                this._firstName = value;
            }
        }

        // Shortcuts for get and set method
        public string LastName
        {
            get => this._lastName;
            set => this._lastName = value;
        }
        public bool IsAlive
        {
            get
            {
                return this._isAlive;
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this._birthYear;
            }
        }
        public Person(string firstName, string lastName, int birthYear, double height)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._birthYear = birthYear;
            this._height = height;
        }
        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;    
            return currentYear - this._birthYear;
        }
        public double GetHeightInFeet()
        {
            double heightInFeet = this._height / 30.48; // 1 foot = 30.48 cm
            return heightInFeet;
        }
        public override string ToString()
        {
            string data = $"Name: {this._firstName} {this._lastName}, Age: {this.GetAge()}, Height: {this.GetHeightInFeet()}ft";
            return data;
        }
    }
}
