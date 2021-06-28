
namespace B21_Ex05_Eithan_204311757_Maor_204709950
{
    partial class GameBoard
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
            this.lblPlayer1GameBoard = new System.Windows.Forms.Label();
            this.lblPlayer2GameBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer1GameBoard
            // 
            this.lblPlayer1GameBoard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPlayer1GameBoard.AutoSize = true;
            this.lblPlayer1GameBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer1GameBoard.Location = new System.Drawing.Point(358, 829);
            this.lblPlayer1GameBoard.Name = "lblPlayer1GameBoard";
            this.lblPlayer1GameBoard.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1GameBoard.TabIndex = 800;
            this.lblPlayer1GameBoard.Text = "Player 1:";
            // 
            // lblPlayer2GameBoard
            // 
            this.lblPlayer2GameBoard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPlayer2GameBoard.AutoSize = true;
            this.lblPlayer2GameBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer2GameBoard.Location = new System.Drawing.Point(505, 829);
            this.lblPlayer2GameBoard.Name = "lblPlayer2GameBoard";
            this.lblPlayer2GameBoard.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2GameBoard.TabIndex = 900;
            this.lblPlayer2GameBoard.Text = "Player 2:";
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 887);
            this.Controls.Add(this.lblPlayer2GameBoard);
            this.Controls.Add(this.lblPlayer1GameBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1GameBoard;
        private System.Windows.Forms.Label lblPlayer2GameBoard;
    }
}