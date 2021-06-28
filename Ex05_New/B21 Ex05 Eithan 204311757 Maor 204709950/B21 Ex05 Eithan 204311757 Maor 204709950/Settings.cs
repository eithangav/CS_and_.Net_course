using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex05.GameLogic;


namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    public class Settings
    {
        private bool m_IsMultiplayer;
        private string m_Player1Name;
        private string m_Player2Name;
        private int m_Rows;
        private int m_Cols;

        public Settings(bool i_IsMultiplayer, string i_Player1Name, string i_Player2Name, int i_Rows, int i_Cols)
        {
            m_IsMultiplayer = i_IsMultiplayer;
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_Player2Name;
            m_Rows = i_Rows;
            m_Cols = i_Cols;
        }

        public Settings()
        {
            m_IsMultiplayer = false;
            m_Player1Name = "";
            m_Player2Name = "";
            m_Rows = 0;
            m_Cols = 0;
        }

        public bool IsMultiplayer
        {
            get
            {
                return m_IsMultiplayer;
            }
            set
            {
                m_IsMultiplayer = value;
            }
        }
        public string Player1Name
        {
            get
            {
                return m_Player1Name;
            }
            set
            {
                m_Player1Name = value;
            }
        }
        public string Player2Name
        {
            get
            {
                return m_Player2Name;
            }
            set
            {
                m_Player2Name = value;
            }
        }
        public int Rows
        {
            get
            {
                return m_Rows;
            }
            set
            {
                m_Rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return m_Cols;
            }
            set
            {
                m_Cols = value;
            }
        }

    }
}
