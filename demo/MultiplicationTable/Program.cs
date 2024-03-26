using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int col = 10;
            int[,] mtable = new int[row, col];
            for(int i = 0;i<row;i++) 
            {
                for(int j = 0;j<col;j++)
                {
                    mtable[i-1,j-1]=i*j;

                }
            }
            Console.WriteLine("multiplicationTable");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"{mtable[i,j],4 }");
                }
            }
        }
    }
}
