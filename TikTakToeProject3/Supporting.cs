using System;
using System.Collections.Generic;
using System.Text;

namespace TikTakToeProject3
{
    class Supporting
    {
        public void printBoard(char[] board)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        public bool checkWin(char[] board)
        {
            bool win = false;

            //Check for matching rows
            if ((board[0] == board[1] && board[0] == board[2]) || (board[3] == board[4] && board[3] == board[5]) || (board[6] == board[7] && board[6] == board[8]))
            {
                win = true;
            }

            //Check for matching columns
            if ((board[0] == board[3] && board[0] == board[6]) || (board[1] == board[4] && board[1] == board[7]) || (board[2] == board[5] && board[2] == board[8]))
            {
                win = true;
            }

            //Check for matching diagnols
            if ((board[0] == board[4] && board[0] == board[8]) || (board[2] == board[4] && board[2] == board[6]))
            {
                win = true;
            }

            return win;
        }
    }
}
