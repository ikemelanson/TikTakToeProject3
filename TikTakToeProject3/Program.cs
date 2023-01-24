using System;

namespace TikTakToeProject3
{
    class Program
    {
        static void Main(string[] args)
        {



            // Welcome the user to the game
            Console.WriteLine("Hello, Welcome to Group 1's Tic Tac Toe Game!");

            // Create a game, board array and player variables
            Supporting game = new Supporting();
            // char[] gameBoard = new char[9];
            char[] gameBoard = {'0', '1', '2', '3', '4', '5', '6', '7', '8'};
            char player1 = 'X';
            char player2 = 'O';
            int turnCheck = 0;
            int position = 0;

            Console.WriteLine("Player 1 you are X's and Player 2 you are O's.");
            Console.WriteLine("Player 1 starts...");

            do // Start and Play the game
            {
                
                do
                {
                    if (turnCheck % 2 == 0) //Check for player's turn
                    {
                        game.printBoard(gameBoard);
                        Console.Write("\nPlayer 1, choose a number to correspond to the space (0-8) ");

                        position = Convert.ToInt32(Console.ReadLine());
                        while ((gameBoard[position] == 'X') || (gameBoard[position] == 'O'))
                        {
                            Console.Write("\nPlayer 1, enter a number that has not already been used ");
                            position = Convert.ToInt32(Console.ReadLine());

                        }
                        gameBoard[position] = player1;
                        turnCheck++;

                        
                    }
                    else
                    {
                        game.printBoard(gameBoard);
                        Console.Write("\nPlayer 2, choose a number to correspond to the space (0-8) ");
                        position = Convert.ToInt32(Console.ReadLine());
                        while ((gameBoard[position] == 'X') || (gameBoard[position] == 'O'))
                        {
                            Console.Write("\nPlayer 2, enter a number that has not already been used ");
                            position = Convert.ToInt32(Console.ReadLine());

                        }
                        gameBoard[position] = player2;
                        turnCheck++;
                    }
                } while ((gameBoard[position] != 'X') || (gameBoard[position] != 'O')); //Check if user inputs a number where there is already a symbol
                

                game.printBoard(gameBoard); // Print resulting board
            }
            while (game.checkWin(gameBoard) == false);

            game.checkWin(gameBoard);


            /*
            • Ask each player in turn for their choice and update the game board array
            • Print the board by calling the method in the supporting class
            • Check for a winner by calling the method in the supporting class, and notify the players
              when a win has occurred and which player won the game
            */


        }
    }
}
