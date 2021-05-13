using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex02
{
    public class Tournament
    {
        private byte m_Player1Score;
        private byte m_Player2Score;
        private bool m_IsMultiplayer;
        private byte m_BoardSize;
        private Game m_Game;
        private GameUI m_GameUI;

        /* Constructor.
         * Init primitives, get user's size and mode inputs
         * and run the first game. */
        public Tournament()
        {
            m_Player1Score = 0;
            m_Player2Score = 0;

            m_BoardSize = GameUI.InsertBoardSizeMsg();
            m_IsMultiplayer = GameUI.IsMultiplayerMsg();

            gameRun();
        }

<<<<<<< HEAD
        private void RunGame()
=======
        /* Game runner - Init Game and GameUI and iteratively runs new round
         * until a game is ended. */
        private void gameRun()
>>>>>>> ec969105d82867cf774865836f0dae06ded6b02b
        {
            m_Game = new Game(m_BoardSize, m_IsMultiplayer);
            m_GameUI = new GameUI(m_Game);

            m_GameUI.PrintBoard();
<<<<<<< HEAD
        }
=======
            Cell usersChoice = m_GameUI.InsertNextPlayerMoveMsg();
            int roundResult = m_Game.PlayerMove(usersChoice);
>>>>>>> ec969105d82867cf774865836f0dae06ded6b02b

            while(roundResult == 0)
            {
                m_GameUI.PrintBoard();
                usersChoice = m_GameUI.InsertNextPlayerMoveMsg();
                roundResult = m_Game.PlayerMove(usersChoice);
            }

            gameEnd(roundResult);
        }
<<<<<<< HEAD
=======

        /* End a game - Prints the result, asks  */
        private void gameEnd(int gameResult)
        {
            if (gameResult == 3)
            {
                m_GameUI.TieGame();
            }
            else if (gameResult == 2)
            {
                m_Player1Score++;
                m_GameUI.PlayerWinMsg(1);
            }
            else if (gameResult == 1)
            {
                m_Player2Score++;
                m_GameUI.PlayerWinMsg(2);
            }

            m_GameUI.PointsStatusMessage(m_Player1Score, m_Player2Score);

            if (m_GameUI.PlayAgainMsg())
            {
                gameRun();
            }
        }
>>>>>>> ec969105d82867cf774865836f0dae06ded6b02b
    }
}