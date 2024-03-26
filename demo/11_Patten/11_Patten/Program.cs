using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Patten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for(i=4; i>=0;i--)
            {
                for(k=4; k>i; k--)
                {
                    Console.WriteLine("");
                }
                for(j=1;j<(k*2);j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
        }
    }
}
