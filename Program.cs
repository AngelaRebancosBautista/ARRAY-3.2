using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];

            Console.WriteLine("Enter your 5 favorite fruits");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Fruit {i + 1}: ");
                fruits[i] = Console.ReadLine().ToLower();
            }
            int appleCount = 0;
            foreach (string fruit in fruits)
            {
                if (fruit == "apple")
                {
                    appleCount++;
                }
            }
            Console.WriteLine("\nYour favorite fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine("- " + fruit);
            }
            Console.WriteLine($"\nNumber of times 'apple' appears: {appleCount}");
        }
    }
}
            
