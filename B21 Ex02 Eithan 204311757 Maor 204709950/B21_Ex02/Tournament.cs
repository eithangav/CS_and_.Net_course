﻿using System;
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
        private int m_BoardSize;
        private Game m_Game;
        private GameUI m_GameUI;

        public Tournament()
        {
            this.m_Player1Score = 0;
            this.m_Player2Score = 0;
            this.m_ComputerScore = 0;
        }

        public void StartTournament()
        {

        }

        public void StartNewGame() 
        {

        }



    }
}