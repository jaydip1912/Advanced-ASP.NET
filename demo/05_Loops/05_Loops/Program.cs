using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"for loop iteration {i}");
            }

            int j = 1;
            while (j<= 5)
            {   
                Console.WriteLine($"While loop iteration {j}");
                j++;
            }
        }
    }
}
