using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _17_FunctionOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circleArea = CircleArea(4);
            Print("Area of the circle: "+circleArea);
            Console.WriteLine();
            double a = 4;
            double b = 5;
            Print($"Is {a} greater than {b} -> {IsGreaterThan(a, b)}");

            Console.WriteLine();
            // Point inside circle or not
            double centerX = 0;
            double centerY = 0;
            double radius = 1;
            double pointX = 3;
            double pointY = 5;
            bool isInside = PointLocation(centerX, centerY, radius, pointX, pointY);
            Console.WriteLine($"Is point {(pointX, pointY)} inside circle with radius {radius}? {isInside}");
            Console.WriteLine();
            // Average of numbers
            double[] numbers = new double[7] {2.5, 5, 3.9, 4.2, 6.1, 7.3, 8.0};
            double average = AverageOfNumbers(numbers);
            Print($"Average of numbers: {average}");
            Console.WriteLine();

            // Numeric series
            int start = 2;
            int step = 3;
            int count = 7;
            double[] series = NumericSeries(start, step, count);
            Print(series);
            Console.WriteLine();

            // Numeric series with start and end
            double startValue = 1.5;
            double endValue = 10.0;
            double stepValue = 2.0;
            double[] seriesData = NumericSeries(startValue, endValue, stepValue);
            Print(seriesData);

        }
        static void Print(double[] value)
        {
            foreach(double val in value)
            {
                Console.WriteLine(val);
            }
        }
        static void Print(double value)
        {
            Console.WriteLine(value);
        }
        static void Print(string value)
        {
            Console.WriteLine(value);
        }


        static double CircleArea(double radius) => Math.PI * Math.Pow(radius, 2);

        static bool IsGreaterThan(double a, double b) => a>b;

        // Distance between two points
        static double DistanceCalculation(double x0, double y0, double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));
            return distance;
        }

        // Check if a point is inside a circle or not
        static bool PointLocation(double x, double y, double radius, double a, double b)
        {
            double distance = DistanceCalculation(x, y, a, b);
            bool isInside = distance < radius;
            return isInside;
        }

        //Average of numbers
        static double AverageOfNumbers(double[] numbers)
        {
            double sum = 0;
            int count = numbers.Length;
            foreach(double num in numbers)
            {
                sum = sum + num;
            }
            double average = sum / count;
            return average;
        }

        // Generate sequence with step
        static double[] NumericSeries(double start, double step, int count)
        {
            double[] list = new double[count];
            for(int i=0; i<count; i++)
            {
                list[i] = start + i * step;
            }
            return list;
        }

        // Numeric series with start and end
        static double[] NumericSeries(double start, double end, double step)
        {
            if (end<start)
            {
                throw new ArgumentException("End must be greater than start.");
            }
            int count = (int)(Math.Floor(end-start)/step)+1;
            double[] list = new double[count];

            for(int i=0; i<count; i++)
            {
                list[i] = start + i*step;
            }
            return list;
        }
    }
}
