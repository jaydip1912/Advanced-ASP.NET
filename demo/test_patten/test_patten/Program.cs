using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_patten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for(i=4;i>=0;i--)
            {
                for(j=4;j>i;j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
