using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows : ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter number of cols : ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            double[] avgOfRows = new double[row];

            for (int i = 0; i < row; i++)
            {
                double sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                avgOfRows[i] = sum / col;
                Console.WriteLine($" --> {avgOfRows[i]:f2}");
            }
        }
    }
}
