using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex02
{
    public class GameUI
    {
        private Game m_Game;
        private char[,] m_BoardDrowing;

        public GameUI(Game i_Game)
        {
            m_Game = i_Game;
            m_BoardDrowing = drawInitialBoard();
        }

        //Validates the initial input of board size from the user
        //Returns the selected input size  
        public static byte InsertBoardSizeMsg()
        {
            string boardSize = "";
            bool validInput = false;

            Console.WriteLine("Welcome to `Reverse Tic-Tac-Toe` Game for Console! \n ");
            Console.WriteLine("Please insert board size number between 3 to 9");

            while (!validInput)
            {
                boardSize = Console.ReadLine();
                if(boardSize.Length != 1)
                {
                    Console.WriteLine("Invalid input board size. Please insert number between 3 to 9");
                    continue;
                }
                else if(boardSize.Length == 1)
                {
                    if(byte.Parse(boardSize) < 3 || byte.Parse(boardSize) > 9)
                    {
                        Console.WriteLine("Invalid input board size. Please insert number between 3 to 9");
                        continue;
                    }
                    else
                    {
                        validInput = true;
                        break;
                    }
                }
            }

            return byte.Parse(boardSize);
        }


        //Set the Game Mode 
        public static bool IsMultiplayerMsg()
        {
            string userChoice = "";
            bool validInput = false;
            bool isMultiplayer = false;

            Console.WriteLine("Please select if you would like to play in `Multiplayer Mode` (Y/N)");

            while (!validInput)
            {
                userChoice = Console.ReadLine();
                if(userChoice.Length != 1)
                {
                    Console.WriteLine("Invalid input Game Mode choice. Please insert Y/N");
                    continue;
                }
                else if(userChoice.Length == 1)
                {
                    if(userChoice.ToLower() == "y")
                    {
                        isMultiplayer = true;
                        validInput = true;
                        break;
                    }
                    else if(userChoice.ToLower() == "n")
                    {
                        validInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input Game Mode choice. Please insert Y/N");
                        continue;
                    }
                }
            }

            return isMultiplayer;
        }

        //Validate the user input choice for game moves
        public bool IsValidInputMsg(string i_InputStr)
        {
            bool validPlayerInput = true;
            byte x, y;

            string[] inputAfterSplit = new string[2];

            if(i_InputStr.Length != 3)
            {
                validPlayerInput = false;
            }
            else
            {
                inputAfterSplit = i_InputStr.Split(" ");
                x = byte.Parse(inputAfterSplit[0]);
                y = byte.Parse(inputAfterSplit[1]);

                if(x < 0 || x > m_Game.BoardSize)
                {
                    validPlayerInput = false;
                }
                else if (y < 0 || y > m_Game.BoardSize)
                {
                    validPlayerInput = false;

                }
            }

            return validPlayerInput;
        }


        private char[,] drawInitialBoard()
        {
            byte drowingBoardSize = m_Game.BoardSize * 2 + 2;
            char[,] drowingBoard = new char[drowingBoardSize, drowingBoardSize];


            return drowingBoard;

        }
        public void PrintBoard()
        {


        }

      
        public Cell InsertNextPlayerMoveMsg()
        {
            return new Cell(1, 2);
        }

        public void PlayerWinMsg(byte i_PlayerNumber)
        {

        }

        public bool PlayAgainMsg()
        {
            return false;
        }


        public void CellIsUsedMsg(Cell i_Cell)
        {

        }
    }
}
