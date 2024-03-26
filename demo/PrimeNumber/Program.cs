using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number=int.Parse(Console.ReadLine());
            int count=0;
            for(int i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==2) 
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime"); 
            }
        }
    }
}
