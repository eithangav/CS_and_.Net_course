using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex05.GameUI;
using Ex05.GameLogic;

namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    public partial class GameSettingsForm : Form
    {

        private const string m_MissingFieldsMessage = "Some fields are missing!";
        private const string m_ErrorTitle = "Error";

        private Settings m_GameSettings;

        private string m_ComputerName = "Computer";

        public Settings GameSetings
        {
            get
            {
                return m_GameSettings;
            }
        }


        public GameSettingsForm()
        {
            InitializeComponent();
            m_GameSettings = new Settings(); // TODO: initialize in "btnStartGameSettings_Click" instead (by the overloading new CTOR)
        }


        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.Enabled = true;
            textBoxPlayer2.Text = "";
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;

        }

        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Value = numericUpDownCols.Value;

        }

        private void btnStartGameSettings_Click(object sender, EventArgs e)
        {
            //heck wether all the require fields were filled by the user
            if (checkNotEmptyFields())
            {
                m_GameSettings.IsMultiplayer = checkBoxPlayer2.Checked;
                m_GameSettings.Player1Name = textBoxPlayer1.Text;

                //Used to convert `[Computer]` -> `Computer`
                if (!m_GameSettings.IsMultiplayer)
                {
                    m_GameSettings.Player2Name = m_ComputerName;
                }
                else
                {
                    m_GameSettings.Player2Name = textBoxPlayer2.Text;

                }

                m_GameSettings.BoardSize = (byte)numericUpDownRows.Value;

                DialogResult = DialogResult.OK;

                Close();
            }
            else
            {
                MessageBox.Show(m_MissingFieldsMessage, m_ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkNotEmptyFields()
        {
            bool isFieldsNotEmpty;

            if (checkBoxPlayer2.Checked)
            {
                isFieldsNotEmpty = !string.IsNullOrEmpty(textBoxPlayer1.Text)
                                   && !string.IsNullOrWhiteSpace(textBoxPlayer1.Text)
                                   && !string.IsNullOrEmpty(textBoxPlayer2.Text)
                                   && !string.IsNullOrWhiteSpace(textBoxPlayer2.Text);
            }

            else
            {
                isFieldsNotEmpty = !string.IsNullOrEmpty(textBoxPlayer1.Text)
                                   && !string.IsNullOrWhiteSpace(textBoxPlayer1.Text);
            }

            return isFieldsNotEmpty;
        }
    }
}
