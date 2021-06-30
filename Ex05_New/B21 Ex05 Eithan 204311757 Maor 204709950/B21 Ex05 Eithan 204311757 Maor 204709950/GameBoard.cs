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

    public partial class GameBoard : Form
    {
        private Game m_Game;
        private Settings m_GameSettings;

        private int m_BoardSize;
        private string m_Player1Name;
        private string m_Player2Name;

        private List<Button> m_Buttons;

        //Initialize Game Board with the apropriate Game and GameSettinigs
        public GameBoard(Settings i_GameSettings, Game i_Game)
        {
            InitializeComponent();
            m_Game = i_Game;
            m_GameSettings = i_GameSettings;
            m_BoardSize = m_Game.BoardSize;
            m_Player1Name = m_GameSettings.Player1Name;
            m_Player2Name = m_GameSettings.Player2Name;
            m_Buttons = initializeButtons();
        }

        /// <summary>
        /// Creates a list of Buttons acording to the board size
        /// </summary>
        /// <returns></returns>
        private List<Button> initializeButtons()
        {
            List<Button> Buttons = new List<Button>();
            for (int i = 0; i < m_BoardSize; i++)
            {
                Buttons.Add(new Button());
            }

            return Buttons;
        }
    }
}
