using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a board : ");
            char[,] board = new char[3, 3];
           
            for (int i = 0; i < 3; i++)
            {
                string[] rows = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < 3; j++)
                {
                    if (rows[j].Length > 0)
                    {
                        board[i, j] = rows[j][0];
                    }
                }
            }
            
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '\0') 
                {
                    Console.WriteLine($"Winner : [{board[i, 0]}]");
                    return;
                }

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != '\0')
                {
                    Console.WriteLine($"Winner: [{board[0, i]}]");
                    return;
                }
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '\0')
            {
                Console.WriteLine($"Winner: [{board[0, 0]}]");
                return;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '\0')
            {
                Console.WriteLine($"Winner: [{board[0, 2]}]");
                return;
            }
            Console.WriteLine("No winner");
        }
    }
}
