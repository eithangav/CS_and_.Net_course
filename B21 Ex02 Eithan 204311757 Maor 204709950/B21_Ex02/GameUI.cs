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
          
            string welcomeMsg = "Welcome to `Reverse Tic-Tac-Toe` Game for Console! \n ";
            string insertBoardSizeMsg = "Please insert board size number between 3 to 9";
            string invalidInputMsg = "Invalid input board size. Please insert number between 3 to 9";

            Console.WriteLine(welcomeMsg);
            Console.WriteLine(insertBoardSizeMsg);

            while (!validInput)
            {
                boardSize = Console.ReadLine();
                if(boardSize.Length != 1)
                {
                    Console.WriteLine(invalidInputMsg);
                    continue;
                }
                else if(boardSize.Length == 1)
                {
                    if(byte.Parse(boardSize) < 3 || byte.Parse(boardSize) > 9)
                    {
                        Console.WriteLine(invalidInputMsg);
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
           
            string selectGameModeMsg = "Please select if you would like to play in `Multiplayer Mode` (Y/N)";
            string invalidInputMsg = "Invalid input Game Mode choice. Please insert Y/N";

            Console.WriteLine(selectGameModeMsg);

            while (!validInput)
            {
                userChoice = Console.ReadLine();
                if(userChoice.Length != 1)
                {
                    Console.WriteLine(invalidInputMsg);
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
                        Console.WriteLine(invalidInputMsg);
                        continue;
                    }
                }
            }

            return isMultiplayer;
        }


        //Prints the user 
        public void PlayerWinMsg(byte i_PlayerNumber)
        {
            Console.WriteLine(String.Format("Congragulation Player {} won the game!", i_PlayerNumber));

        }


        //TODO
        public void TieGame(byte i_PlayerNumber)
        {
            Console.WriteLine(String.Format("Congragulation Player {} won the game!", i_PlayerNumber));

        }


        //Checks if the user would like to play another round
        public bool PlayAgainMsg()
        {
            bool isValidInput = false;
            bool isPlayAgain = false;
            string userInput = "";

            string isPlayAgainMsg = "The game is over. \n Would you like to play another round? (Y/N)";
            string invalidMsg = "Invalid choice. Would you like to play another round ? (insert Y/N)";

            Console.WriteLine(isPlayAgainMsg);

            while (!isValidInput)
            {
                userInput = Console.ReadLine();

                if (userInput.Length != 1)
                {
                    Console.WriteLine(invalidMsg);
                    continue;
                }
                else if (userInput.Length == 1)
                {
                    if (userInput.ToLower() == "y")
                    {
                        isPlayAgain = true;
                        isValidInput = true;
                        break;
                    }
                    else if (userInput.ToLower() == "n")
                    {
                        isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(invalidMsg);
                        continue;
                    }
                }
            }

            if(isPlayAgain)
            {
                Console.Clear();
            }

            return isPlayAgain;
        }


        public void CellIsUsedMsg(Cell i_Cell)
        {
            Console.WriteLine(string.Format("The cell {} has already filled. /n Please select another cell", i_Cell));

        }


        //Gets the desired input cell from the player
        //TODO:
        //if IsEmptyCell(cell) from gamereturn CellIsUseMsg
        //return cell
        public Cell InsertNextPlayerMoveMsg()
        {
            Cell newCell;
            bool isValidInput = false;
            string userInputCell = "";
            int playerNumber = m_Game.PlayedLast + 1;
            
            string insertValueMsg = "Player {0}, insert desired cell values in range {1} (format: number space number. Example: `1 3`)";
            string invalidMsg = "Invalid input. Insert desired cell values in range {0} format: `number space number`. Example: `1 3`";

            Console.WriteLine(string.Format(insertValueMsg, playerNumber, m_Game.BoardSize));

            while (!isValidInput)
            {
                userInputCell = Console.ReadLine();

                if(userInputCell.Length != 3)
                {
                    Console.WriteLine(string.Format(invalidMsg, m_Game.BoardSize));
                    continue;
                }
                else if(userInputCell.Length == 3)
                {
                    if(userInputCell[1] != ' ')
                    {
                        Console.WriteLine(string.Format(invalidMsg, m_Game.BoardSize));
                        continue;
                    }
                    else if(userInputCell[0] < 0 || userInputCell[0] > m_Game.BoardSize)
                    {
                        Console.WriteLine(string.Format(invalidMsg, m_Game.BoardSize));
                        continue;
                    }
                    else if (userInputCell[2] < 0 || userInputCell[2] > m_Game.BoardSize)
                    {
                        Console.WriteLine(string.Format(invalidMsg, m_Game.BoardSize));
                        continue;
                    }
                    else
                    {
                        isValidInput = true;
                        break;
                    }
                }
            }

            //TODO:
            if (isValidInput)
            {
                Console.Clear();
            }

            newCell = new Cell((byte)(userInputCell[0]), (byte)(userInputCell[2]));

            return newCell;
        }

        //Validate the user input choice for game moves
        //
        private Cell IsValidInput(string i_InputStr)
        {
            bool validPlayerInput = true;
            byte x, y;

            string[] inputAfterSplit = new string[2];

            if (i_InputStr.Length != 3)
            {
                validPlayerInput = false;
            }
            else
            {
                inputAfterSplit = i_InputStr.Split(" ");
                x = byte.Parse(inputAfterSplit[0]);
                y = byte.Parse(inputAfterSplit[1]);

                if (x < 0 || x > m_Game.BoardSize)
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


        //TODO
        private void drawInitialBoard()
        {
            byte drowingBoardSize = (byte)(m_Game.BoardSize * 2 + 2);
            char[,] drowingBoard = new char[drowingBoardSize, drowingBoardSize];



        }


        //TODO
        public void PrintBoard()
        {


        }
    }
}
