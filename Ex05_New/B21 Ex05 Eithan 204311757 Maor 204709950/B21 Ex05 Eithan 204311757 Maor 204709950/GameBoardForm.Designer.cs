
namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    partial class GameBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelPlayer1Name = new System.Windows.Forms.Label();
            this.LabelPlayer2Name = new System.Windows.Forms.Label();
            this.LabelPlayer1Score = new System.Windows.Forms.Label();
            this.LabelPlayer2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPlayer1Name
            // 
            this.LabelPlayer1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlayer1Name.AutoSize = true;
            this.LabelPlayer1Name.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer1Name.Location = new System.Drawing.Point(35, 454);
            this.LabelPlayer1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayer1Name.Name = "LabelPlayer1Name";
            this.LabelPlayer1Name.Size = new System.Drawing.Size(70, 17);
            this.LabelPlayer1Name.TabIndex = 800;
            this.LabelPlayer1Name.Text = "Player 1:";
            // 
            // LabelPlayer2Name
            // 
            this.LabelPlayer2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlayer2Name.AutoSize = true;
            this.LabelPlayer2Name.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer2Name.Location = new System.Drawing.Point(166, 465);
            this.LabelPlayer2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayer2Name.Name = "LabelPlayer2Name";
            this.LabelPlayer2Name.Size = new System.Drawing.Size(65, 17);
            this.LabelPlayer2Name.TabIndex = 900;
            this.LabelPlayer2Name.Text = "Player 2:";
            // 
            // LabelPlayer1Score
            // 
            this.LabelPlayer1Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlayer1Score.AutoSize = true;
            this.LabelPlayer1Score.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer1Score.Location = new System.Drawing.Point(360, 332);
            this.LabelPlayer1Score.Name = "LabelPlayer1Score";
            this.LabelPlayer1Score.Size = new System.Drawing.Size(18, 17);
            this.LabelPlayer1Score.TabIndex = 901;
            this.LabelPlayer1Score.Text = "0";
            // 
            // LabelPlayer2Score
            // 
            this.LabelPlayer2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlayer2Score.AutoSize = true;
            this.LabelPlayer2Score.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer2Score.Location = new System.Drawing.Point(293, 440);
            this.LabelPlayer2Score.Name = "LabelPlayer2Score";
            this.LabelPlayer2Score.Size = new System.Drawing.Size(17, 17);
            this.LabelPlayer2Score.TabIndex = 902;
            this.LabelPlayer2Score.Text = "0";
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 549);
            this.Controls.Add(this.LabelPlayer2Score);
            this.Controls.Add(this.LabelPlayer1Score);
            this.Controls.Add(this.LabelPlayer2Name);
            this.Controls.Add(this.LabelPlayer1Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelPlayer2Name;
        private System.Windows.Forms.Label LabelPlayer1Score;
        private System.Windows.Forms.Label LabelPlayer2Score;
        public System.Windows.Forms.Label LabelPlayer1Name;
    }
}