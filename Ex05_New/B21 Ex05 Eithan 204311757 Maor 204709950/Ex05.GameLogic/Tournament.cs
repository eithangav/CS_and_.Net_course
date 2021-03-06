using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.GameLogic
{
    public class Tournament
    {
        private byte m_Player1Score;
        private byte m_Player2Score;
        private Settings m_Settings;

        private Game m_CurrentGame;

        public Tournament(Settings i_Settings)
        {
            m_Player1Score = 0;
            m_Player2Score = 0;
            m_Settings = i_Settings;
            m_CurrentGame = new Game(m_Settings.BoardSize, m_Settings.IsMultiplayer);
        }

        public void NewRound()
        {
            updateScore();

            eGameResult lastGameResult = m_CurrentGame.GameResult;
            m_CurrentGame = new Game(m_Settings.BoardSize, m_Settings.IsMultiplayer);
        }

        private void updateScore()
        {
            switch (m_CurrentGame.GameResult)
            {
                case eGameResult.PlayerOneLose:
                    m_Player2Score++;
                    break;
                case eGameResult.PlayerTwoLose:
                    m_Player1Score++;
                    break;
            }
        }

        public Settings Settings
        {
            get
            {
                return m_Settings;
            }
        }

        public Game CurrentGame
        {
            get
            {
                return m_CurrentGame;
            }
        }

        public byte Player1Score
        {
            get
            {
                return m_Player1Score;
            }
        }

        public byte Player2Score
        {
            get
            {
                return m_Player2Score;
            }
        }
    }
}
