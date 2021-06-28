using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.GameUI
{
    public partial class GameSettings : Form
    {
        private const string m_MissingFieldsMessage = "Some fields are missing!";
        private const string m_ErrorTitle = "Error";

        private TournamentLogic tournament;

        /*   private bool m_IsMultiplayer;
           private string m_Player1Name;
           private string m_Player2Name;
           private int m_Rows;
           private int m_Cols;*/

        private Settings m_GameSettings;

       

        public GameSettings()
        {
            InitializeComponent();
            m_GameSettings = new Settings();
        }

        //Return the Game Settings that were update 
        public Settings GameSetings
        {
            get
            {
                return m_GameSettings;
            }
        }

        private void textBoxPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.Enabled = true;
            textBoxPlayer2.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Value = numericUpDownCols.Value;
        }

        private void btnStartGameSettings_Click(object sender, EventArgs e)
        {
            //heck wether all the require fields were filled by the user
            if (checkNotEmptyFields())
            {
                //If true - update the game settings
                m_GameSettings.IsMultiplayer = checkBoxPlayer2.Checked;
                m_GameSettings.Player1Name = textBoxPlayer1.Text;
                m_GameSettings.Player2Name = textBoxPlayer2.Text;
                m_GameSettings.Rows = (int)numericUpDownRows.Value;
                m_GameSettings.Cols = (int)numericUpDownCols.Value;

                DialogResult = DialogResult.OK;

                tournament = new TournamentLogic(m_GameSettings);

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

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Minimum = 3;
            numericUpDownRows.Maximum = 9;
            numericUpDownCols.Value = numericUpDownRows.Value;

        }

        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Minimum = 3;
            numericUpDownCols.Maximum = 9;
            numericUpDownRows.Value = numericUpDownCols.Value;



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }


    }
}
