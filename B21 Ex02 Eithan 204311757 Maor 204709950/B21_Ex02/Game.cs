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
            m_BoardSize = i_BoardSize;
            m_IsMultiplayer = i_IsMultiplayer;
            boardInitializer(m_BoardSize); 

        }

        
        private void boardInitializer(byte i_BoardSize)
        {
            m_Board = new char[i_BoardSize, i_BoardSize];

            for(int i=0; i< i_BoardSize; i++)
            {
                for(int j=0; j<i_BoardSize; j++)
                {
                    m_Board.SetValue(' ', j);
                }
            }
        }

        public byte PlayerMove(Cell i_Cell)
        {
            return 1;
        }

        private byte computerMove()
        {
            return 1;
        }

        private void updateCell(Cell i_Cell)
        {
            m_Board[i_Cell.row, i_Cell.column] = currentPlayerSign();
            m_FilledCells++;
        } 

        private bool isEmptyCell(Cell i_Cell)
        {
            return m_Board[i_Cell.row, i_Cell.column] == ' ';
        }

        private bool didLose(Cell i_Cell)
        {
            char currentSign = currentPlayerSign();

            // Check column
            bool columnSequence = true;

            // not imlemented yet
            for(int i=0; i<m_BoardSize; i++)
            {
                if(m_Board[i, i_Cell.column] != currentSign)
                {
                    columnSequence = false;
                }
            }

            return false;
        }

        private bool isTie()
        {
            return Math.Pow(m_BoardSize, 2) == m_FilledCells;
        }

        private Cell randomCellInitializer()
        {
            return new Cell(1, 2);
        }

        public char[,] Board
        {
            get
            {
                return m_Board;
            }
        }

        public byte BoardSize
        {
            get
            {
                return m_BoardSize;
            }
        }

        public byte PlayedLast
        {
            get
            {
                return (byte)(m_FilledCells % 2 + 1);
            }
        }

        private char currentPlayerSign()
        {
            char cellContent;

            if (this.PlayedLast == 1)
            {
                cellContent = 'O';
            }
            else
            {
                cellContent = 'X';
            }

            return cellContent;
        }




    }

    
}
