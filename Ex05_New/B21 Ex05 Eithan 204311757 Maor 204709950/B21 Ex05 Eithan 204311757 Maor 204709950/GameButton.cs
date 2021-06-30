using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    internal class GameButton : Button
    {
        private readonly Cell r_Position;
        private const int k_Height = 40;
        private const int k_Width = 50;

        public GameButton(Cell i_ButtonPosition)
        {
            r_Position = i_ButtonPosition;
            this.Enabled = true;
            this.Height = k_Height;
            this.Width = k_Width;
        }

        public Cell Position
        {
            get
            {
                return r_Position;
            }
        }
    }
}
