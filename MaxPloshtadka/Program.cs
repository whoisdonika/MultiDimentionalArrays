using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPloshtadka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num of rows : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter num of cols : ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, row];
            
            for (int i = 0; i < row; i++)
            {
                string[] rows = Console.ReadLine().Split();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(rows[j]);
                }
            }

            int maxSum = int.MinValue;
            int maxRow = -1, maxCol = -1;
            
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{matrix[maxRow, maxCol]}" +
                $" {matrix[maxRow, maxCol + 1]}");
            
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]}" +
                $" {matrix[maxRow + 1, maxCol + 1]}");
           
        }
    }
    
}
