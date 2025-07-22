using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ASCII_ArtUsingFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII Art using Function");
            Console.Write("Endter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Endter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Endter border width: ");
            double borderWdith = Convert.ToDouble(Console.ReadLine());
            DrawASCII(width, height, borderWdith);
        }
        static void DrawASCII(double width, double height, double borderWdith)
        {
            for(int j=0; j<height; j++)
            {
                for(int i=0; i<width; i++)
                {
                    if (j<borderWdith || j>height-1-borderWdith || i<borderWdith || i>width-1-borderWdith)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
