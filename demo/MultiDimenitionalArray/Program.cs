using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimenitionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int col = 3;
            int[,] matrix=new int[row, col];
            Random random = new Random();

            for (int i = 0; i < row; i++) 
            {
                for (int j = 0; j < col; j++) 
                {
                    matrix[i, j] = random.Next(1,10);
                }
            }
            Console.WriteLine("matrix");
            for (int i = 0;i<row;i++)
            {
                for(int j = 0;j < col;j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
