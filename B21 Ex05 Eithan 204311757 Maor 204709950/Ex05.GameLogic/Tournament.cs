using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05.GameLogic
{
    public class Tournament
    {
        private byte m_Player1Score;
        private byte m_Player2Score;

        private readonly bool m_IsMultiplayer;
        private readonly byte m_BoardSize;

        private Game m_Game;
        private GameUI m_GameUI; // TODO: modify

        /* Constructor.
         * Init primitives, get user's size and mode inputs
         * and run the first game. */
        public Tournament()
        {
            m_Player1Score = 0;
            m_Player2Score = 0;
            
            m_BoardSize = 4; //TODO: replace with the value of the user's size input (instead of: GameUI.InsertBoardSizeMsg)
            m_IsMultiplayer = false; //TODO: replace with the value of the user's isMultiplayer input (instead of: GameUI.IsMultiplayerMsg)

            gameRun();
        }

        /* Game runner - Init Game and GameUI and iteratively runs new round
         * until a game is ended. */
        private void gameRun()
        {
            m_Game = new Game(m_BoardSize, m_IsMultiplayer);
            m_GameUI = new GameUI(m_Game); // TODO: modify

            eGameResult roundResult = eGameResult.Pending;
            Cell usersChoice = new Cell(255,255);

            while(roundResult == 0)
            {
                usersChoice = m_GameUI.InsertNextPlayerMoveMsg(); // TODO: modify
                roundResult = m_Game.PlayerMove(usersChoice);
                m_GameUI.PrintBoard(m_Game.Board); // TODO: modify
            }

            gameEnd(roundResult);
        }

        /* End a game - Prints the result, asks  */
        private void gameEnd(eGameResult i_GameResult)
        {
            switch (i_GameResult) // TODO: modify all UI methods
            {
                case eGameResult.Quit:
                    m_GameUI.QuitMsg();
                    break;
                case eGameResult.Tie:
                    m_GameUI.TieGameMsg();
                    break;
                case eGameResult.PlayerTwoLose:
                    m_GameUI.PlayerWinMsg(1);
                    break;
                case eGameResult.PlayerOneLose:
                    m_GameUI.PlayerWinMsg(2);
                    break;
            }

            m_GameUI.PointStatusMsg(m_Player1Score, m_Player2Score); // TODO: modify

            if (m_GameUI.PlayAgainMsg()) // TODO: modify
            {
                gameRun();
            }
        }
    }
}