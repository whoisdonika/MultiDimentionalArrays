using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num of rows : ");
            int rows = int.Parse(Console.ReadLine());
            long[][] triangle = new long[rows + 1][];

            for (int row = 0; row < rows; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int space = 0; space < rows - row - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{triangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
