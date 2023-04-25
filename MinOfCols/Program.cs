
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOfCols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num of rows : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter num of cols : ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            
            for (int i = 0; i < row; i++)
            {
                string[] elements = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    
                    matrix[i, j] = int.Parse(elements[j]);
                }
            }
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            
            int[] minOfCols = new int[col];
            
            for (int i = 0; i < minOfCols.Length; i++)
            {
                minOfCols[i] = int.MaxValue;
            }
            
            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (matrix[i, j] < minOfCols[j])
                    {
                        minOfCols[j] = matrix[i, j];
                    }
                }
            }
            foreach (int min in minOfCols)
            {
                Console.Write($"{min} ");
            }
            Console.WriteLine();
        }
    }
    
}
