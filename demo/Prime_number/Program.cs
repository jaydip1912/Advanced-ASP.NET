using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            if(num %2==0) 
            {
                Console.WriteLine("numer is prime");
            }
            else
            {
                Console.WriteLine("mumber not prime");
            }
            
        }
    }
}
