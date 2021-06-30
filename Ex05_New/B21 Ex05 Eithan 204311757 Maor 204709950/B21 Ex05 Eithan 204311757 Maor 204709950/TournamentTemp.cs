using System;
using System.Collections.Generic;
using System.Text;
using Ex05.GameLogic;
using B21_Ex05_Eithan_204311757_Maor_204709950;
using System.Windows.Forms;

namespace Ex05.GameUI
{
    public class TournamentTemp
    {
        private byte m_Player1Score;
        private byte m_Player2Score;

        private B21_Ex05_Eithan_204311757_Maor_204709950.SettingsTemp m_Settings;
        private GameSettingsForm m_GameSettingForm;

        private readonly bool m_IsMultiplayer;
        private readonly byte m_BoardSize;


        private Game m_Game;
        private GameBoardForm m_GameBoard;


        /// <summary>
        /// Constructor. 
        /// Init primitives, get user's size and mode inputs and run the first game.
        /// </summary>
        public TournamentTemp()
        {
            m_GameSettingForm = new GameSettingsForm(); //Lunch a Game Setttings Form
            Application.Run(m_GameSettingForm);

            m_Settings = m_GameSettingForm.GameSetings; //Sets the user choice Game Settings 

            m_IsMultiplayer = m_Settings.IsMultiplayer;
            m_BoardSize = (byte)(m_Settings.Rows * m_Settings.Cols);

            m_Player1Score = 0;
            m_Player2Score = 0;

            gameRun();
        }


        /// <summary>
        /// Game runner - Init Game and GameBoard and iteratively runs new round
        /// until a game is ended
        /// </summary>
        private void gameRun()
        {
            m_Game = new Game(m_BoardSize, m_IsMultiplayer);
            m_GameBoard = new GameBoardForm(m_Settings, m_Game);

            Application.Run(m_GameBoard); //lunch the Game Board Form

            Cell usersChoice = new Cell(255,255);

            while(m_Game.GameResult == eGameResult.Pending)
            {
                //usersChoice = m_GameBoard  //TODO: modify - Add event listeners to the buttons change
                m_Game.PlayerMove(usersChoice);
                //m_GameUI.PrintBoard(m_Game.Board); // TODO: modify
            }

            // gameEnd(roundResult);
        }


        /// <summary>
        /// TODO: 
        /// End a game - Prints the result, asks...............................
        /// </summary>
        /// <param name="i_GameResult"></param>
        /*private void gameEnd(eGameResultLogic i_GameResult)
        {
            switch (i_GameResult) // TODO: modify all UI methods
            {
                case eGameResultLogic.Quit:
                    m_GameUI.QuitMsg();
                    break;
                case eGameResultLogic.Tie:
                    m_GameUI.TieGameMsg();
                    break;
                case eGameResultLogic.PlayerTwoLose:
                    m_GameUI.PlayerWinMsg(1);
                    break;
                case eGameResultLogic.PlayerOneLose:
                    m_GameUI.PlayerWinMsg(2);
                    break;
            }

            m_GameUI.PointStatusMsg(m_Player1Score, m_Player2Score); // TODO: modify

            if (m_GameUI.PlayAgainMsg()) // TODO: modify
            {
                gameRun();
            }
        }*/
    }
}