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
        private List<GameButton> m_GameButtons;

        public GameBoardForm(Tournament i_Tournament)
        {
            InitializeComponent();

            lblPlayer1GameBoard.Text = m_Tournament.Settings.Player1Name;
            lblPlayer2GameBoard.Text = m_Tournament.Settings.Player2Name;

            initializeButtons();
        }

        private void initializeButtons()
        {
            byte boardSize = m_Tournament.Settings.BoardSize;
            m_GameButtons = new List<GameButton>();

            for (byte i = 0; i < boardSize; i++)
            {
                for(byte j = 0; j < boardSize; j++)
                {
                    GameButton button = new GameButton(new Cell(i, j));
                    // TODO: continue here

                }
            }
        }
    }
}
