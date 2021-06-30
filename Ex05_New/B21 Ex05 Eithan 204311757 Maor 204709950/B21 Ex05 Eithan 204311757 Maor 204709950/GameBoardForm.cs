using Ex05.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    /**TODO:
     * Handle adding the buttons List to the board (show wise)
     * Handle show the user choice and sign in the game board
     * Handle get user choice from the board - handle apropiately in the Game class
     * Handle change user current playing mark up (bold) the current pkayer turn (player 1 / player 2)
     * Handle MessageBox.Show for a tie / win and play abother round
     * Handle `Player 1` & `Player 2` name convention to user choice name / Computer (if in game mode - Player2Name = computer)
     */

    public partial class GameBoardForm : Form
    {
        private Tournament m_Tournament;

        private List<Button> m_Buttons;

        //Initialize Game Board with the apropriate Game and GameSettinigs
        public GameBoardForm(Tournament i_Tournament)
        {
            InitializeComponent();
            //initializeButtons();
        }

        /// <summary>
        /// Creates a list of Buttons acording to the board size
        /// </summary>
        private void initializeButtons()
        {
            int numOfButtons = (int)Math.Pow(m_Tournament.Settings.BoardSize, 2);
            m_Buttons = new List<Button>();

            for (int i = 0; i < numOfButtons; i++)
            {
                m_Buttons.Add(new Button());
            }
        }
    }
}
