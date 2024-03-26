using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;
            int columns = 10;
            int[,] multiplicationTable = new int[rows, columns];
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    multiplicationTable[i - 1, j - 1] = i * j;
                }
            }
            Console.WriteLine("Multiplication Table:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write($"{multiplicationTable[i, j]+" "}");
                }
                Console.WriteLine();
            }

        }
    }
}
