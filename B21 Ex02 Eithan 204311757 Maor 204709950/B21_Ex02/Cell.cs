﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex02
{
    public struct Cell
    {
        public byte row;
        public byte column;

        public Cell(byte i_Row, byte i_Column)
        {
            this.row = i_Row;
            this.column = i_Column;

        }
    }
}
