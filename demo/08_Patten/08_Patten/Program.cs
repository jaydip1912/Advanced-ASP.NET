using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Patten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 6; i >= 1 ;i --)
            {
                for (int k = 1; k < i; k++)   
                {
                    Console.Write(" ");
                }
                for (int j = 6; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
