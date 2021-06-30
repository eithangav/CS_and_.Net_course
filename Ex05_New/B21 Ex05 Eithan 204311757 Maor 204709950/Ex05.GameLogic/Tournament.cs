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
        private string m_Player1Name;
        private string m_Player2Name;

        private readonly bool r_IsMultiplayer;
        private readonly byte r_BoardSize;

        private Game m_CurrentGame;

        public Tournament(byte i_BoardSize, string i_Player1Name, string i_Player2Name = "Computer", bool i_IsMultiplayer = false)
        {
            m_Player1Score = 0;
            m_Player2Score = 0;
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_Player2Name;
            r_IsMultiplayer = i_IsMultiplayer;
            r_BoardSize = i_BoardSize;

            m_CurrentGame = new Game(r_BoardSize, r_IsMultiplayer);
        }

        public eGameResult NewRound()
        {
            updateScore();

            eGameResult lastGameResult = m_CurrentGame.GameResult;
            m_CurrentGame = new Game(r_BoardSize, r_IsMultiplayer);

            return lastGameResult;
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
                default:
                    // Do nothing
                    break;
            }
        }
    }
}
