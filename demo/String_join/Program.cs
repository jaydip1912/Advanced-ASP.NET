using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String st1 = "jay";
            String st2 = "dip";
            String st3=st1 + st2;
            String st4=String.Concat(st1, st2);
            Console.WriteLine(st3);
            Console.WriteLine(st4);
        }
    }
}
