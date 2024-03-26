using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, };
            Console.WriteLine("Array Elements");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
