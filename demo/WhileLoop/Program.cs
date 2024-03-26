using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j;
            while(i<=5)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                i++;
            }
          

        }
    }
    
}
