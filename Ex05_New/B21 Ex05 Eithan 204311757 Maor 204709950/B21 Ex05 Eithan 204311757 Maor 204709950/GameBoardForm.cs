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

        private const int k_SpaceBuffer = 8;

        public GameBoardForm(Tournament i_Tournament)
        {
            m_Tournament = i_Tournament;
            InitializeComponent();

            initializeButtons();
            initializeBoard();
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
                    Point buttonLocation = new Point((k_SpaceBuffer + button.Width) * i + k_SpaceBuffer,
                        (k_SpaceBuffer + button.Height) * j + k_SpaceBuffer);
                    button.Location = buttonLocation;
                    //button.Click += gameButton_Click;
                    Controls.Add(button);
                    m_GameButtons.Add(button);
                }
            }
        }

        private void initializeBoard()
        {
            byte boardSize = m_Tournament.Settings.BoardSize;

            // Set form size:
            int labelsHeight = LabelPlayer1Name.Height;
            int formWidth = (GameButton.sr_Width + k_SpaceBuffer) * boardSize + k_SpaceBuffer;
            int formHeight = (GameButton.sr_Height + k_SpaceBuffer) * boardSize + (k_SpaceBuffer * 3) + labelsHeight;

            Size size = new Size(formWidth, formHeight);
            this.Size = size;
            this.ClientSize = size;

            // Set labels text:
            LabelPlayer1Name.Text = m_Tournament.Settings.Player1Name + ": ";
            LabelPlayer2Name.Text = m_Tournament.Settings.Player2Name + ": ";
            LabelPlayer1Score.Text = "0";
            LabelPlayer2Score.Text = "0";

            // Set labels location:
            int labelsWidth = LabelPlayer1Name.Width + LabelPlayer2Name.Width + 
                LabelPlayer1Score.Width + LabelPlayer2Score.Width + (2 * k_SpaceBuffer);

            int currentLeftStartPosition = (formWidth - labelsWidth) / 2;
            int topStartPosition = formHeight - labelsHeight - k_SpaceBuffer;

            LabelPlayer1Name.Location = new Point(currentLeftStartPosition, topStartPosition);
            currentLeftStartPosition += LabelPlayer1Name.Width;
            LabelPlayer1Score.Location = new Point(currentLeftStartPosition, topStartPosition);
            currentLeftStartPosition += LabelPlayer1Score.Width + (2 * k_SpaceBuffer);
            LabelPlayer2Name.Location = new Point(currentLeftStartPosition, topStartPosition);
            currentLeftStartPosition += LabelPlayer2Name.Width;
            LabelPlayer2Score.Location = new Point(currentLeftStartPosition, topStartPosition);
        }
    }
}
