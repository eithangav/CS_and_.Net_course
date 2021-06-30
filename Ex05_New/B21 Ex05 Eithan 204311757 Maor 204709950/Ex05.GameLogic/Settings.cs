using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.GameLogic
{
    public class Settings
    {
        private bool m_IsMultiplayer;
        private string m_Player1Name;
        private string m_Player2Name;
        private byte m_BoardSize;

        public Settings(byte i_BoardSize, string i_Player1Name, bool i_IsMultiplayer = false, string i_Player2Name = "Computer")
        {
            m_IsMultiplayer = i_IsMultiplayer;
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_IsMultiplayer ? i_Player2Name : "Computer";
            m_BoardSize = i_BoardSize;
        }

        public Settings()
        {
            m_IsMultiplayer = false;
            m_Player1Name = "";
            m_Player2Name = "";
            m_BoardSize = 0;
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
        public byte BoardSize
        {
            get
            {
                return m_BoardSize;
            }
            set
            {
                m_BoardSize = value;
            }
        }
    }
}
