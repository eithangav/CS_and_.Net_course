using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace Ex05.GameUI
{
    public class Tournament
    {
        private byte m_Player1Score;
        private byte m_Player2Score;

        private readonly bool m_IsMultiplayer;
        private readonly byte m_BoardSize;

        private Game m_Game;
        private Settings m_Settings;

        /* Constructor.
         * Init primitives, get user's size and mode inputs
         * and run the first game. */
        public Tournament()
        {
            m_Player1Score = 0;
            m_Player2Score = 0;

            GameUI.GameSettings SettingsForm = new GameUI.GameSettings();



            m_BoardSize = 4; //TODO: replace with the value of the user's size input (instead of: GameUI.InsertBoardSizeMsg)
            m_IsMultiplayer = false; //TODO: replace with the value of the user's isMultiplayer input (instead of: GameUI.IsMultiplayerMsg)

            gameRun();
        }

        /* Game runner - Init Game and GameUI and iteratively runs new round
         * until a game is ended. */
        private void gameRun()
        {
            m_Game = new Game(m_BoardSize, m_IsMultiplayer);
            // TODO: Instantiate Forms

            eGameResult roundResult = eGameResult.Pending;
            Cell usersChoice = new Cell(255,255);

            while(roundResult == 0)
            {
                //usersChoice = m_GameUI.InsertNextPlayerMoveMsg(); // TODO: modify
                roundResult = m_Game.PlayerMove(usersChoice);
                //m_GameUI.PrintBoard(m_Game.Board); // TODO: modify
            }

            //gameEnd(roundResult);
        }

        
    }
}