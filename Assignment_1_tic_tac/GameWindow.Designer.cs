namespace Assignment_1_tic_tac
{
    partial class GameWindow
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
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.richTextBoxPlayerMovesConsole = new System.Windows.Forms.RichTextBox();
            this.labelPlayerWinsCount2 = new System.Windows.Forms.Label();
            this.labelPlayerWinsCount1 = new System.Windows.Forms.Label();
            this.labelPlayerWins2 = new System.Windows.Forms.Label();
            this.labelPlayerWins1 = new System.Windows.Forms.Label();
            this.labelPlayerTurn = new System.Windows.Forms.Label();
            this.labelTurn = new System.Windows.Forms.Label();
            this.buttonArray9 = new System.Windows.Forms.Button();
            this.buttonArray8 = new System.Windows.Forms.Button();
            this.buttonArray7 = new System.Windows.Forms.Button();
            this.buttonArray6 = new System.Windows.Forms.Button();
            this.buttonArray5 = new System.Windows.Forms.Button();
            this.buttonArray4 = new System.Windows.Forms.Button();
            this.buttonArray3 = new System.Windows.Forms.Button();
            this.buttonArray2 = new System.Windows.Forms.Button();
            this.buttonArray1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Location = new System.Drawing.Point(344, 215);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(60, 40);
            this.buttonPlayAgain.TabIndex = 35;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.Location = new System.Drawing.Point(278, 215);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(60, 40);
            this.buttonResetGame.TabIndex = 34;
            this.buttonResetGame.Text = "Reset Game";
            this.buttonResetGame.UseVisualStyleBackColor = true;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // richTextBoxPlayerMovesConsole
            // 
            this.richTextBoxPlayerMovesConsole.Location = new System.Drawing.Point(279, 115);
            this.richTextBoxPlayerMovesConsole.Name = "richTextBoxPlayerMovesConsole";
            this.richTextBoxPlayerMovesConsole.Size = new System.Drawing.Size(125, 83);
            this.richTextBoxPlayerMovesConsole.TabIndex = 33;
            this.richTextBoxPlayerMovesConsole.Text = "";
            this.richTextBoxPlayerMovesConsole.TextChanged += new System.EventHandler(this.richTextBoxPlayerMovesConsole_TextChanged);
            // 
            // labelPlayerWinsCount2
            // 
            this.labelPlayerWinsCount2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayerWinsCount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerWinsCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPlayerWinsCount2.Location = new System.Drawing.Point(340, 80);
            this.labelPlayerWinsCount2.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlayerWinsCount2.Name = "labelPlayerWinsCount2";
            this.labelPlayerWinsCount2.Size = new System.Drawing.Size(63, 20);
            this.labelPlayerWinsCount2.TabIndex = 32;
            this.labelPlayerWinsCount2.Text = "0 wins";
            // 
            // labelPlayerWinsCount1
            // 
            this.labelPlayerWinsCount1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayerWinsCount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerWinsCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPlayerWinsCount1.Location = new System.Drawing.Point(279, 80);
            this.labelPlayerWinsCount1.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlayerWinsCount1.Name = "labelPlayerWinsCount1";
            this.labelPlayerWinsCount1.Size = new System.Drawing.Size(63, 20);
            this.labelPlayerWinsCount1.TabIndex = 31;
            this.labelPlayerWinsCount1.Text = "0 wins";
            // 
            // labelPlayerWins2
            // 
            this.labelPlayerWins2.AutoSize = true;
            this.labelPlayerWins2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayerWins2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerWins2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPlayerWins2.Location = new System.Drawing.Point(340, 61);
            this.labelPlayerWins2.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlayerWins2.Name = "labelPlayerWins2";
            this.labelPlayerWins2.Size = new System.Drawing.Size(63, 20);
            this.labelPlayerWins2.TabIndex = 30;
            this.labelPlayerWins2.Text = "Player 2";
            // 
            // labelPlayerWins1
            // 
            this.labelPlayerWins1.AutoSize = true;
            this.labelPlayerWins1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayerWins1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerWins1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPlayerWins1.Location = new System.Drawing.Point(279, 61);
            this.labelPlayerWins1.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlayerWins1.Name = "labelPlayerWins1";
            this.labelPlayerWins1.Size = new System.Drawing.Size(63, 20);
            this.labelPlayerWins1.TabIndex = 29;
            this.labelPlayerWins1.Text = "Player 1";
            // 
            // labelPlayerTurn
            // 
            this.labelPlayerTurn.AutoSize = true;
            this.labelPlayerTurn.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelPlayerTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelPlayerTurn.Location = new System.Drawing.Point(336, 18);
            this.labelPlayerTurn.Margin = new System.Windows.Forms.Padding(0);
            this.labelPlayerTurn.Name = "labelPlayerTurn";
            this.labelPlayerTurn.Size = new System.Drawing.Size(78, 24);
            this.labelPlayerTurn.TabIndex = 28;
            this.labelPlayerTurn.Text = "Player 0";
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelTurn.Location = new System.Drawing.Point(278, 18);
            this.labelTurn.Margin = new System.Windows.Forms.Padding(0);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(60, 24);
            this.labelTurn.TabIndex = 27;
            this.labelTurn.Text = "Turn :";
            // 
            // buttonArray9
            // 
            this.buttonArray9.Location = new System.Drawing.Point(182, 180);
            this.buttonArray9.Name = "buttonArray9";
            this.buttonArray9.Size = new System.Drawing.Size(75, 75);
            this.buttonArray9.TabIndex = 26;
            this.buttonArray9.UseVisualStyleBackColor = true;
            this.buttonArray9.Click += new System.EventHandler(this.buttonArray9_Click);
            // 
            // buttonArray8
            // 
            this.buttonArray8.Location = new System.Drawing.Point(101, 180);
            this.buttonArray8.Name = "buttonArray8";
            this.buttonArray8.Size = new System.Drawing.Size(75, 75);
            this.buttonArray8.TabIndex = 25;
            this.buttonArray8.UseVisualStyleBackColor = true;
            this.buttonArray8.Click += new System.EventHandler(this.buttonArray8_Click);
            // 
            // buttonArray7
            // 
            this.buttonArray7.Location = new System.Drawing.Point(20, 180);
            this.buttonArray7.Name = "buttonArray7";
            this.buttonArray7.Size = new System.Drawing.Size(75, 75);
            this.buttonArray7.TabIndex = 24;
            this.buttonArray7.UseVisualStyleBackColor = true;
            this.buttonArray7.Click += new System.EventHandler(this.buttonArray7_Click);
            // 
            // buttonArray6
            // 
            this.buttonArray6.Location = new System.Drawing.Point(182, 99);
            this.buttonArray6.Name = "buttonArray6";
            this.buttonArray6.Size = new System.Drawing.Size(75, 75);
            this.buttonArray6.TabIndex = 23;
            this.buttonArray6.UseVisualStyleBackColor = true;
            this.buttonArray6.Click += new System.EventHandler(this.buttonArray6_Click);
            // 
            // buttonArray5
            // 
            this.buttonArray5.Location = new System.Drawing.Point(101, 99);
            this.buttonArray5.Name = "buttonArray5";
            this.buttonArray5.Size = new System.Drawing.Size(75, 75);
            this.buttonArray5.TabIndex = 22;
            this.buttonArray5.UseVisualStyleBackColor = true;
            this.buttonArray5.Click += new System.EventHandler(this.buttonArray5_Click);
            // 
            // buttonArray4
            // 
            this.buttonArray4.Location = new System.Drawing.Point(20, 99);
            this.buttonArray4.Name = "buttonArray4";
            this.buttonArray4.Size = new System.Drawing.Size(75, 75);
            this.buttonArray4.TabIndex = 21;
            this.buttonArray4.UseVisualStyleBackColor = true;
            this.buttonArray4.Click += new System.EventHandler(this.buttonArray4_Click);
            // 
            // buttonArray3
            // 
            this.buttonArray3.Location = new System.Drawing.Point(182, 18);
            this.buttonArray3.Name = "buttonArray3";
            this.buttonArray3.Size = new System.Drawing.Size(75, 75);
            this.buttonArray3.TabIndex = 20;
            this.buttonArray3.UseVisualStyleBackColor = true;
            this.buttonArray3.Click += new System.EventHandler(this.buttonArray3_Click);
            // 
            // buttonArray2
            // 
            this.buttonArray2.Location = new System.Drawing.Point(101, 18);
            this.buttonArray2.Name = "buttonArray2";
            this.buttonArray2.Size = new System.Drawing.Size(75, 75);
            this.buttonArray2.TabIndex = 19;
            this.buttonArray2.UseVisualStyleBackColor = true;
            this.buttonArray2.Click += new System.EventHandler(this.buttonArray2_Click);
            // 
            // buttonArray1
            // 
            this.buttonArray1.Location = new System.Drawing.Point(20, 18);
            this.buttonArray1.Name = "buttonArray1";
            this.buttonArray1.Size = new System.Drawing.Size(75, 75);
            this.buttonArray1.TabIndex = 18;
            this.buttonArray1.UseVisualStyleBackColor = true;
            this.buttonArray1.Click += new System.EventHandler(this.buttonArray1_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 273);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.richTextBoxPlayerMovesConsole);
            this.Controls.Add(this.labelPlayerWinsCount2);
            this.Controls.Add(this.labelPlayerWinsCount1);
            this.Controls.Add(this.labelPlayerWins2);
            this.Controls.Add(this.labelPlayerWins1);
            this.Controls.Add(this.labelPlayerTurn);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.buttonArray9);
            this.Controls.Add(this.buttonArray8);
            this.Controls.Add(this.buttonArray7);
            this.Controls.Add(this.buttonArray6);
            this.Controls.Add(this.buttonArray5);
            this.Controls.Add(this.buttonArray4);
            this.Controls.Add(this.buttonArray3);
            this.Controls.Add(this.buttonArray2);
            this.Controls.Add(this.buttonArray1);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.RichTextBox richTextBoxPlayerMovesConsole;
        private System.Windows.Forms.Label labelPlayerWinsCount2;
        private System.Windows.Forms.Label labelPlayerWinsCount1;
        private System.Windows.Forms.Label labelPlayerWins2;
        private System.Windows.Forms.Label labelPlayerWins1;
        private System.Windows.Forms.Label labelPlayerTurn;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Button buttonArray9;
        private System.Windows.Forms.Button buttonArray8;
        private System.Windows.Forms.Button buttonArray7;
        private System.Windows.Forms.Button buttonArray6;
        private System.Windows.Forms.Button buttonArray5;
        private System.Windows.Forms.Button buttonArray4;
        private System.Windows.Forms.Button buttonArray3;
        private System.Windows.Forms.Button buttonArray2;
        private System.Windows.Forms.Button buttonArray1;
    }
}