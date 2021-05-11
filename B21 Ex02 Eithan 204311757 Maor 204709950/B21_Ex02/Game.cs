using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex02
{
    public class Game
    {
        private char[,] m_Board;
        private byte m_FilledCells;
        private byte m_BoardSize;
        private bool m_IsMultiplayer;

        public Game(byte i_BoardSize, bool i_IsMultiplayer)
        {
            this.m_BoardSize = i_BoardSize;
            this.m_IsMultiplayer = i_IsMultiplayer;
            boardInitializer(m_BoardSize); 

        }

        
        private void boardInitializer(byte i_BoardSize)
        {

        }

        public byte PlayerMove(byte i_Row, byte i_Column)
        {
            return 1;
        }

        private byte computerMove()
        {
            return 1;
        }

        private void updateCell(byte i_Row, byte i_Column)
        {

        } 

        private bool isEmptyCell(byte i_Row, byte i_Column)
        {
            return true;
        }

        private bool didLose()
        {
            return false;
        }

        private bool isTie()
        {
            
            return false;
        }

        private Cell randomCellInitializer()
        {
            
        }

        public char[,] Board
        {
            get
            {
                return m_Board;
            }
        }

        public byte PlayedLast
        {
            get
            {
                return (byte)(m_FilledCells % 2 + 1);
            }
        }





    }

    
}
