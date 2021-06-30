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
        private readonly GameSettingsForm r_GameSettingsForm;
        private GameBoardForm m_GameBoardForm;
        private Tournament m_Tournament;

        public GameLauncher()
        {
            r_GameSettingsForm = new GameSettingsForm();
        }

        public void Launch()
        {
            r_GameSettingsForm.ShowDialog();

            m_Tournament = new Tournament(r_GameSettingsForm.GameSetings);

            m_GameBoardForm = new GameBoardForm(m_Tournament);

            m_GameBoardForm.ShowDialog();
        }
    }
}
