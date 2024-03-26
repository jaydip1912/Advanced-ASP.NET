using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Example01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        Console.WriteLine("{" + array1[i] + "," + array1[j] + "}");
                    }
                    else
                    {
                        Console.WriteLine("{" + array1[i] + "," + array1[j] + "},");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
