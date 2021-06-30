
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
            this.lblPlayer1GameBoard = new System.Windows.Forms.Label();
            this.lblPlayer2GameBoard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayer1GameBoard
            // 
            this.lblPlayer1GameBoard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPlayer1GameBoard.AutoSize = true;
            this.lblPlayer1GameBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer1GameBoard.Location = new System.Drawing.Point(177, 539);
            this.lblPlayer1GameBoard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1GameBoard.Name = "lblPlayer1GameBoard";
            this.lblPlayer1GameBoard.Size = new System.Drawing.Size(69, 20);
            this.lblPlayer1GameBoard.TabIndex = 800;
            this.lblPlayer1GameBoard.Text = "Player 1:";
            // 
            // lblPlayer2GameBoard
            // 
            this.lblPlayer2GameBoard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPlayer2GameBoard.AutoSize = true;
            this.lblPlayer2GameBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer2GameBoard.Location = new System.Drawing.Point(379, 539);
            this.lblPlayer2GameBoard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2GameBoard.Name = "lblPlayer2GameBoard";
            this.lblPlayer2GameBoard.Size = new System.Drawing.Size(69, 20);
            this.lblPlayer2GameBoard.TabIndex = 900;
            this.lblPlayer2GameBoard.Text = "Player 2:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(251, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 901;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(453, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 902;
            this.label2.Text = "0";
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer2GameBoard);
            this.Controls.Add(this.lblPlayer1GameBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayer2GameBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPlayer1GameBoard;
    }
}