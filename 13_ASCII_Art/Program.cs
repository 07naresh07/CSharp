using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ASCII_Art
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine()); 

            for (int j=0; j<height; j++)
            {
                for(int i=0; i<width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int borderWidth = 2;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (j < borderWidth || j > height - 1 - borderWidth || i < borderWidth || i > width - 1 - borderWidth)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if((i+j)%2==0)
                    {
                        Console.Write("░");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Creating pyramid pattern
            int pyramidWidth = 2 * height - 1;
            int pyramidHeight = height;
            int centerColumn = pyramidHeight - 1;
            for (int j = 0; j < pyramidHeight; j++)
            {
                for (int i = 0; i < pyramidWidth; i++)
                {
                    if (i>=centerColumn-j && i<=centerColumn+j)
                    {
                        Console.Write("▀");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Creating circle
            Console.WriteLine("Circle:");
            double centerX = width / 2.0;
            double centerY = height / 2.0;
            double radius = Math.Min(centerX, centerY);
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    double distance = Math.Sqrt(Math.Pow(i - centerX, 2) + Math.Pow(j - centerY, 2));
                    if(distance<radius)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
