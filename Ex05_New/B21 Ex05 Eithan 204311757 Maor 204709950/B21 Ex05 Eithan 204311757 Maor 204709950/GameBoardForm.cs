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
    public partial class GameBoardForm : Form
    {
        private Tournament m_Tournament;
        private GameButton[,] m_GameButtons;

        private const int k_SpaceBuffer = 8;
        private bool m_IsPlayer1Turn;

        private readonly Font r_boldLabel;
        private readonly Font r_regularLabel;

        public GameBoardForm(Tournament i_Tournament)
        {
            m_Tournament = i_Tournament;
            m_IsPlayer1Turn = true;
            r_boldLabel = new Font("MV Boli", 10F, FontStyle.Bold);
            r_regularLabel = new Font("MV Boli", 10F, FontStyle.Regular);

            InitializeComponent();

            initializeButtons();
            initializeBoard();
        }

        /// <summary>
        /// Triggers when a game button is clicked
        /// </summary>
        private void gameButton_Click(object sender, EventArgs e)
        {
            GameButton clickedButton = sender as GameButton;

            if(clickedButton != null)
            {
                Game currentGame = m_Tournament.CurrentGame;

                // update user's choice on the button
                clickedButton.Text = currentGame.CurrentPlayerSign().ToString();
                clickedButton.Enabled = false;

                // compare last played cell to the clicked cell in order to get a computer choice Cell if exists
                Cell clickedCell = clickedButton.Position;
                Cell lastPlayedCell = currentGame.PlayerMove(clickedCell);

                if (!m_Tournament.Settings.IsMultiplayer && 
                    (lastPlayedCell.m_Row != clickedCell.m_Row || lastPlayedCell.m_Column != clickedCell.m_Column))
                {
                    GameButton computerSelectedButton = m_GameButtons[lastPlayedCell.m_Row, lastPlayedCell.m_Column];
                    computerSelectedButton.Text = "O";
                    computerSelectedButton.Enabled = false;

                }

                // in case the round is over, pop an alert and handle the users choice, otherwise- switch turn
                DialogResult result = DialogResult.None;

                switch (currentGame.GameResult)
                {
                    case eGameResult.PlayerOneLose:
                        result = MessageBox.Show(LabelPlayer1Name.Text.Replace(":", "") + " Wins!\nWould you like to play another round?", "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        handleAlertResult(result);
                        break;
                    case eGameResult.PlayerTwoLose:
                        result = MessageBox.Show(LabelPlayer2Name.Text.Replace(":","") + "Wins!\nWould you like to play another round?", "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        handleAlertResult(result);
                        break;
                    case eGameResult.Tie:
                        result = MessageBox.Show("This is a Tie!\nWould you like to play another round?", "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        handleAlertResult(result);
                        break;
                    default:
                        switchTurn();
                        break;
                }
            }
        }

        /// <summary>
        /// handles the pop up alert message result
        /// Yes - resets the current game and sets a new round
        /// No - closes the form
        /// </summary>
        /// <param name="i_Result"></param>
        private void handleAlertResult(DialogResult i_Result)
        {
            switch (i_Result)
            {
                case DialogResult.Yes:
                    endOfRound();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }

        /// <summary>
        /// resets the tournament's current game and sets the visuals properly
        /// </summary>
        private void endOfRound()
        {
            m_Tournament.NewRound();
            LabelPlayer1Score.Text = m_Tournament.Player1Score.ToString();
            LabelPlayer2Score.Text = m_Tournament.Player2Score.ToString();
            cleanBoard();
            if (!m_IsPlayer1Turn)
            {
                switchTurn();
            }
        }

        /// <summary>
        /// cleans the game button's text and makes them clickable
        /// </summary>
        private void cleanBoard()
        {
            byte boardSize = m_Tournament.Settings.BoardSize;

            for(byte i = 0; i < boardSize; i++)
            {
                for(byte j = 0; j < boardSize; j++)
                {
                    m_GameButtons[i, j].Text = "";
                    m_GameButtons[i, j].Enabled = true;
                }
            }
        }

        /// <summary>
        /// Switches turns - flips the "Bold" state of the player's labels and scores
        /// </summary>
        private void switchTurn()
        {
            if (m_Tournament.Settings.IsMultiplayer)
            {
                m_IsPlayer1Turn = !m_IsPlayer1Turn;
                LabelPlayer1Name.Font = LabelPlayer1Name.Font.Bold ? r_regularLabel : r_boldLabel;
                LabelPlayer2Name.Font = LabelPlayer2Name.Font.Bold ? r_regularLabel : r_boldLabel;
                LabelPlayer1Score.Font = LabelPlayer1Score.Font.Bold ? r_regularLabel : r_boldLabel;
                LabelPlayer2Score.Font = LabelPlayer2Score.Font.Bold ? r_regularLabel : r_boldLabel;
            }
        }

        /// <summary>
        /// Creates all of the required game buttons corresponding to the user's settings
        /// </summary>
        private void initializeButtons()
        {
            byte boardSize = m_Tournament.Settings.BoardSize;
            m_GameButtons = new GameButton[boardSize, boardSize];

            for (byte i = 0; i < boardSize; i++)
            {
                for (byte j = 0; j < boardSize; j++)
                {
                    GameButton button = new GameButton(new Cell(i, j));
                    Point buttonLocation = new Point((k_SpaceBuffer + button.Width) * i + k_SpaceBuffer,
                        (k_SpaceBuffer + button.Height) * j + k_SpaceBuffer);
                    button.Location = buttonLocation;
                    button.Click += gameButton_Click;
                    Controls.Add(button);
                    m_GameButtons[i, j] = button;
                }
            }
        }

        /// <summary>
        /// Initializes the board's objects content
        /// </summary>
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
