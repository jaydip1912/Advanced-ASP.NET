using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Patten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)
            {
                for(int j = 6; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
