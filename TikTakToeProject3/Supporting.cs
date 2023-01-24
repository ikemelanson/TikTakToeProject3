using System;
using System.Collections.Generic;
using System.Text;

namespace TikTakToeProject3
{
    class Supporting
    {
        public void printBoard(char[] board)
        {
            for ( int outer = 0; outer < board.GetLength(0); outer++)
            {
                for (int inner = 0; inner < board.GetLength(1); inner++)
                {
                    Console.Write(inner + "\t|\t");
                }
                Console.WriteLine();
            }
        }

        public bool checkWin(char[] board)
        {


            return true;
        }
    }
}
