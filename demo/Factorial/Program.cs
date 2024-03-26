using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static int Factorial(int num) 
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num*Factorial(num-1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=int.Parse(Console.ReadLine());
            int result = Factorial(num);
            Console.WriteLine(result);
        }
    }
}
