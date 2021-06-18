using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05.GameLogic
{
    public struct Cell
    {
        public byte m_Row;
        public byte m_Column;

        public Cell(byte i_Row, byte i_Column)
        {
            this.m_Row = i_Row;
            this.m_Column = i_Column;

        }
    }
}
