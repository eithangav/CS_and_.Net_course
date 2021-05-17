using System;


namespace B21_Ex02
{
    class Program
    {

        static void Main()
        {
            Tournament turnament = new Tournament();

            /*    Game game = new Game(3, true); // just for sintax use. erelevant values 

                char[,] gameBoard = game.Board;
                byte n = 9;
                byte drowingBoardSize = (byte)(n + 1);
                char[,] drowingBoard = new char[drowingBoardSize, drowingBoardSize];

                //Initialize drawing board
                for (int row = 0; row < drowingBoardSize; row++)
                {
                    for (int col = 0; col < drowingBoardSize; col++)
                    {
                        drowingBoard[row, col] = ' ';
                    }
                }

                drowingBoard[1, 1] = 'X';
                drowingBoard[2, 2] = 'X';
                drowingBoard[3, 3] = 'X';
                drowingBoard[4, 4] = 'X';
                drowingBoard[5, 5] = 'X';
                drowingBoard[9, 9] = 'X';

                int countCol = 1;
                int countRow = 1;

                //Printing drawing board
                for (int row = 0; row < drowingBoardSize; row++)
                {
                    if (row > 0)
                    {
                        Console.Write(countRow + " | ");
                        countRow++;
                    }
                    for (int col = 0; col < drowingBoardSize; col++)
                    {
                        if (row == 0 && col > 0)
                        {
                            Console.Write("   " + countCol + "    ");
                            countCol++;
                        }

                        else if (row > 0 && col == 0)
                        {
                            Console.Write("  ");
                        }

                        else if (row > 0)
                        {
                            Console.Write(drowingBoard[row, col]);
                            Console.Write("   |   ");

                        }

                    }
                    if (row == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {

                        Console.WriteLine("\n");
                        Console.Write("  ");
                        for (int i = 0; i < drowingBoardSize; i++)
                        {
                            Console.Write("=======");
                        }
                        Console.WriteLine("\n");
                    }
                }*/
        }
    }
}