
namespace Ex05.GameUI
{
    partial class GameSettings
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
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
<<<<<<< HEAD
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.lblBoardSize = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.btnStartGameSettings = new System.Windows.Forms.Button();
=======
            this.lblBoardSize = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCollumns = new System.Windows.Forms.Label();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayers
            // 
<<<<<<< HEAD
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayers.Location = new System.Drawing.Point(42, 27);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(106, 30);
=======
            this.lblPlayers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayers.Location = new System.Drawing.Point(30, 19);
            this.lblPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(70, 20);
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            this.lblPlayers.TabIndex = 0;
            this.lblPlayers.Text = "Players:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
<<<<<<< HEAD
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer1.Location = new System.Drawing.Point(73, 82);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(92, 26);
=======
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer1.Location = new System.Drawing.Point(53, 57);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(60, 17);
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player1:";
            // 
            // checkBoxPlayer2
            // 
<<<<<<< HEAD
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxPlayer2.Location = new System.Drawing.Point(78, 124);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(118, 30);
            this.checkBoxPlayer2.TabIndex = 2;
=======
            this.checkBoxPlayer2.AccessibleDescription = "";
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxPlayer2.Location = new System.Drawing.Point(56, 84);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(79, 21);
            this.checkBoxPlayer2.TabIndex = 3;
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            this.checkBoxPlayer2.Text = "Player2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
<<<<<<< HEAD
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(223, 82);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(208, 26);
            this.textBoxPlayer1.TabIndex = 3;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(223, 128);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(208, 26);
            this.textBoxPlayer2.TabIndex = 4;
            this.textBoxPlayer2.Text = "[Computer]";
            // 
            // lblBoardSize
            // 
            this.lblBoardSize.AutoSize = true;
            this.lblBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBoardSize.Location = new System.Drawing.Point(42, 194);
            this.lblBoardSize.Name = "lblBoardSize";
            this.lblBoardSize.Size = new System.Drawing.Size(145, 30);
            this.lblBoardSize.TabIndex = 5;
            this.lblBoardSize.Text = "Board Size:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(169, 264);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(57, 26);
            this.numericUpDownRows.TabIndex = 6;
=======
            // lblBoardSize
            // 
            this.lblBoardSize.AutoEllipsis = true;
            this.lblBoardSize.AutoSize = true;
            this.lblBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBoardSize.Location = new System.Drawing.Point(30, 123);
            this.lblBoardSize.Name = "lblBoardSize";
            this.lblBoardSize.Size = new System.Drawing.Size(92, 20);
            this.lblBoardSize.TabIndex = 5;
            this.lblBoardSize.Text = "BoardSize:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(101, 158);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownRows.TabIndex = 7;
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            this.numericUpDownRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
<<<<<<< HEAD
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(371, 264);
            this.numericUpDownCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(60, 26);
            this.numericUpDownCols.TabIndex = 7;
=======
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // lblRows
            // 
            this.lblRows.AutoEllipsis = true;
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRows.Location = new System.Drawing.Point(44, 157);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(46, 17);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows:";
            // 
            // lblCollumns
            // 
            this.lblCollumns.AutoEllipsis = true;
            this.lblCollumns.AutoSize = true;
            this.lblCollumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCollumns.Location = new System.Drawing.Point(167, 159);
            this.lblCollumns.Name = "lblCollumns";
            this.lblCollumns.Size = new System.Drawing.Size(39, 17);
            this.lblCollumns.TabIndex = 8;
            this.lblCollumns.Text = "Cols:";
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(221, 159);
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownCols.TabIndex = 9;
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            this.numericUpDownCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
<<<<<<< HEAD
            this.numericUpDownCols.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRows.Location = new System.Drawing.Point(73, 264);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(73, 26);
            this.lblRows.TabIndex = 8;
            this.lblRows.Text = "Rows:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCol.Location = new System.Drawing.Point(287, 264);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(62, 26);
            this.lblCol.TabIndex = 9;
            this.lblCol.Text = "Cols:";
            // 
            // btnStartGameSettings
            // 
            this.btnStartGameSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStartGameSettings.Location = new System.Drawing.Point(47, 345);
            this.btnStartGameSettings.Name = "btnStartGameSettings";
            this.btnStartGameSettings.Size = new System.Drawing.Size(384, 49);
            this.btnStartGameSettings.TabIndex = 10;
            this.btnStartGameSettings.Text = "Start!";
            this.btnStartGameSettings.UseVisualStyleBackColor = true;
            this.btnStartGameSettings.Click += new System.EventHandler(this.btnStartGameSettings_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 475);
            this.Controls.Add(this.btnStartGameSettings);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.lblBoardSize);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayers);
=======
            this.numericUpDownCols.ValueChanged += new System.EventHandler(this.numericUpDownCols_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.Location = new System.Drawing.Point(33, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(226, 31);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlayer1.Location = new System.Drawing.Point(139, 57);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(120, 20);
            this.textBoxPlayer1.TabIndex = 2;
            this.textBoxPlayer1.TextChanged += new System.EventHandler(this.textBoxPlayer1_TextChanged);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.AccessibleDescription = "";
            this.textBoxPlayer2.AccessibleName = "";
            this.textBoxPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(139, 87);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(120, 20);
            this.textBoxPlayer2.TabIndex = 4;
            this.textBoxPlayer2.Text = "[Computer]";
            this.textBoxPlayer2.TextChanged += new System.EventHandler(this.textBoxPlayer2_TextChanged);
            // 
            // GameSettings
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(301, 277);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCollumns);
            this.Controls.Add(this.numericUpDownCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.lblBoardSize);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayers);
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Label lblBoardSize;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Button btnStartGameSettings;
=======
        private System.Windows.Forms.Label lblBoardSize;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCollumns;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
>>>>>>> aff57e3dcdbbbc6d9bd1c7abca515429faefed35
    }
}

