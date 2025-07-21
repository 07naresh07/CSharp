using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[25];
            
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = 5*i;
            }

            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            /* NOTE:
             *  Arrays are stored in contiguous memory locations i.e. elements are stored one after another. Whereas in list
                elements can be stored in non-contiguous memory locations i.e. elements can be stored anywhere in memory but
                each element point the memory address of the next element.
             *  Arrays are better if we know the size of the data in advance and it is fixed.
             *  Removing elements from an array is not possible. We can only replace the values i.e. even if we remove
                an element, the size of the array will remain the same.
             *  Arrays are faster than lists because they are stored in contiguous memory locations.
             *  List takes more memory than arrays because it stores additional information like the size of the list, capacity, etc.
             */
        }
    }
}
