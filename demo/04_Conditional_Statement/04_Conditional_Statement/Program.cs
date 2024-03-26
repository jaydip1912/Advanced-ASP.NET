using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            if (num>0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if (num<1)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}
