using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        static bool gameOn = true;
        static char move = 'X';

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            WhichTurn();
            MakeTurn();
            while (gameOn)
            {
                WhoWon();
                WinnerXO();
                MakeTurn();
            }
            Console.ReadKey();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            } 
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        public static void WhichTurn()
        {
            int countX = 0;
            int countO = 0;
            int countTurns = 0;

            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    if(board[r, c] == 'X')
                    {
                        countX++;
                        countTurns++;
                    }
                    else if (board[r, c] == 'O')
                    {
                        countO++;
                        countTurns++;
                    }
            }
            
            if(gameOn) 
            {
                if (countX == countO)
                {
                    Console.WriteLine("X, make your turn.(row, column)");
                    move = 'X';
                }
                else
                {
                    Console.WriteLine("O, make your turn.(row, column)");
                    move = 'O';
                }
            }

            if(countTurns == 9)
            {
                gameOn = false;
                Console.WriteLine("GAME OVER. ITS A TIE.");
            } 
        }

        public static void MakeTurn()
        {
            if (gameOn)
            {
                int row = int.Parse(Console.ReadLine());
                int column = int.Parse(Console.ReadLine());

                if (board[row, column] == ' ')
                {
                    board[row, column] = move;
                }
                else
                {
                    Console.WriteLine("This field is already taken. Choose another field");
                }

                DisplayBoard();
            } 
        }

        public static int WhoWon()
        {
            if(board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 2] == move)
            {
                return 1;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] == move)
            {
                return 1;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] == move)
            {
                return 1;
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] == move)
            {
                return 1;
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] == move)
            {
                return 1;
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] == move)
            {
                return 1;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] == move)
            {
                return 1;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] == move)
            {
                return 1;
            }

            return 0;

        }

        public static void WinnerXO()
        {
            if(WhoWon() == 1)
            {
                Console.WriteLine($"{move} won! Congratulations!!");
                gameOn = false;
            }
            WhichTurn();
        }
    }
}
