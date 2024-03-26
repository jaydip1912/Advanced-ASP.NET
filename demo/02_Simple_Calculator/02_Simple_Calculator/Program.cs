using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocome to Simple Calculator");
            Console.WriteLine("Plese Enter the First number");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Plese Enter the Second number");
            double num2=Convert.ToDouble(Console.ReadLine());

            double sum=num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is :{sum}");
            Console.ReadLine();
        }
    }
}
