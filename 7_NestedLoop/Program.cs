using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_NestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            string rows = Console.ReadLine();
            Console.Write("Enter number of columns: ");
            string columns = Console.ReadLine();
            int rowCount = Convert.ToInt32(rows);
            int columnCount = Convert.ToInt32(columns);
            for(int i=0; i<rowCount; i++)
            {
                for(int j=0; j<columnCount; j++)
                {
                    Console.Write(i*j);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
