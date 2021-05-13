using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex02
{
    public class Tournament
    {
        private byte m_Player1Score;
        private byte m_Player2Score;
        private byte m_ComputerScore;
        private bool m_IsMultiplayer; 
        private byte m_BoardSize;
        private Game m_Game;
        private GameUI m_GameUI;

        public Tournament()
        {
            m_Player1Score = 0;
            m_Player2Score = 0;
            m_ComputerScore = 0;

            m_BoardSize = GameUI.InsertBoardSizeMsg();
            m_IsMultiplayer = GameUI.IsMultiplayerMsg();

            RunGame();
        }

        private void RunGame() 
        {
            m_Game = new Game(m_BoardSize, m_IsMultiplayer);
            m_GameUI = new GameUI(m_Game);
            
            m_GameUI.PrintBoard();

        public void StartNewGame() 
        {

        }



    }
}
