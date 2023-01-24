using System;

namespace TikTakToeProject3
{
    class Program
    {
        static void Main(string[] args)
        {



            // Welcome the user to the game
            Console.WriteLine("Hello, Welcome to Gorup 1's Tic Tac Toe Game!");

            // Create a game board array to store the players’ choices

            char[,] gameBoard = new char[3,3];

            char x = gameBoard[0,0] = 'A';

            do
            {
                Supporting.printBoard()
            }
            while (Supporting.checkWin() == false);

            /*
            • Ask each player in turn for their choice and update the game board array
            • Print the board by calling the method in the supporting class
            • Check for a winner by calling the method in the supporting class, and notify the players
              when a win has occurred and which player won the game
            */


        }
    }
}
