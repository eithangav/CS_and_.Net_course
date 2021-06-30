using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex05.GameLogic;

namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    internal class GameLauncher
    {
        private readonly GameSettings r_GameSettingsForm;
        private GameBoard m_GameBoardForm;
        private Tournament m_Tournament;

        public GameLauncher()
        {
            r_GameSettingsForm = new GameSettings();
        }

        public void Launch()
        {
            r_GameSettingsForm.ShowDialog();


            //m_GameBoardForm = new GameBoard();
        }


    }
}
