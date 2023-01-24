using System;

namespace TikTakToeProject3
{
    class Program
    {   
        //Created By:

        //Ike Melanson
        //Olivia Morgan
        //Taylor Sabin
        //Parker Warner
        //Devon Wolsleger
        static void Main(string[] args)
        {

            // Welcome the user to the game
            Console.WriteLine("Hello, Welcome to Group 1's Tic Tac Toe Game!");

            // Create a game, board array, and player variables
            Supporting game = new Supporting();
            char[] gameBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char player1 = 'X';
            char player2 = 'O';
            int turnCheck = 0;
            int position = 0;

            Console.WriteLine("Player 1 you are X's and Player 2 you are O's.");
            Console.WriteLine("Player 1 starts...");

            do
            {
                if (turnCheck % 2 == 0) //Check for player's turn
                {
                    game.printBoard(gameBoard);
                    Console.Write("\nPlayer 1, choose a number to correspond to the space (1-9) ");
                    position = Convert.ToInt32(Console.ReadLine());

                    while ((gameBoard[position-1] == 'X') || (gameBoard[position-1] == 'O'))
                    {
                        Console.Write("\nPlayer 1, enter a number that has not already been used ");
                        position = Convert.ToInt32(Console.ReadLine());

                    }
                    gameBoard[position-1] = player1;
                    turnCheck++;
                }

                else
                {
                    game.printBoard(gameBoard);
                    Console.Write("\nPlayer 2, choose a number to correspond to the space (1-9) ");
                    position = Convert.ToInt32(Console.ReadLine());

                    while ((gameBoard[position-1] == 'X') || (gameBoard[position-1] == 'O'))
                    {
                        Console.Write("\nPlayer 2, enter a number that has not already been used ");
                        position = Convert.ToInt32(Console.ReadLine());

                    }
                    gameBoard[position-1] = player2;
                    turnCheck++;
                }

            } while (game.checkWin(gameBoard) == false); //Checks if there is a winner

            turnCheck--; //Remove last turn to check who is the winner
            
            if (turnCheck == 9) //Check if there is a tie 
            {
                Console.WriteLine("\nSorry it is a tie!");
                game.printBoard(gameBoard);
            }
            else //Display winning board and the winner
            {
                Console.WriteLine("Game Over");
                game.printBoard(gameBoard);

                if (turnCheck % 2 == 0) //Check for who won
                {
                    Console.WriteLine("Player 1 is the winner!");
                }
                else
                {
                    Console.WriteLine("Player 2 is the winner!");
                }
            }
        }
    }
}
