using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = "jaydip";
            String str2 = "jaydip";
            String str3 = "jp";
            Boolean rs=str1.Equals(str2);
            Console.WriteLine(rs);
            Boolean rs1 = str1.Equals(str3);
            Console.WriteLine(rs1);
        }
    }
}
