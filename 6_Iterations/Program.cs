using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> favouriteFoods = new List<string>() { string.Empty, "Pizza", "Sushi", "Tacos", "Burgers" };
            for(int i=0; i<favouriteFoods.Count; i++)
            {
                Console.WriteLine($"My {i + 1} favourite food is {favouriteFoods[i]}");
            }
            Console.WriteLine();

            foreach (string food in favouriteFoods)
            {
                Console.WriteLine($"I like {food}");
            }

            int j = 10;
            while (j>0)
            {
                Console.WriteLine(j);
                j--;
            }

            Console.ReadKey();
        }
    }
}
