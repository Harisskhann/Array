using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
