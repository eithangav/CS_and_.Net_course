using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex05.GameLogic;

namespace Ex05.GameUI
{
    public partial class GameBoard : Form
    {
        private Game m_Game;
        private Settings m_GameSettings;
        
        private int m_BoardSize;
        private string player1Name;
        private string player2Name;
        private int m_Rows;

        private List<Button> m_Buttons;

        public GameBoard(Settings i_GameSettings, Game i_Game)
        {
            InitializeComponent();
            m_GameSettings = i_GameSettings;
            m_Game = i_Game;
            m_BoardSize = i_GameSettings.Cols * i_GameSettings.Rows;

            gameInit();
        }

        private void gameInit()
        {
            m_Buttons = new List<Button>();
            for(int i = 0; i < m_BoardSize; i++)
            {
                m_Buttons.Add(new Button());
            }

        }

        private void lblPlayer1Score_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer2Score_Click(object sender, EventArgs e)
        {

        }
    }
}
