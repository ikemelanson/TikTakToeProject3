using System;
using System.Collections.Generic;
using System.Text;

namespace TikTakToeProject3
{
    class Supporting
    {
        public void printBoard(char[] board)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
            Console.WriteLine("   |   |   ");
        }

        public bool checkWin(char[] board)
        {


            return true;
        }
    }
}
