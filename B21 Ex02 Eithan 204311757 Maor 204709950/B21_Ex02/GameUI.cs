using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex02
{
    public class GameUI
    {
        private Game m_Game;

        public GameUI(Game i_Game)
        {
            m_Game = i_Game;
        }

        public static byte InsertBoardSizeMsg()
        {
            return 1;
        }

        public static bool IsMultiplayerMsg()
        {
            return true;
        }

        public bool IsValidInputMsg(string i_InputStr)
        {
            return false;
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
