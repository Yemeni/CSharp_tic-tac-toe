using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1_tic_tac
{
    public partial class GameWindow : Form
    {
        // member variables
        // initialize instaces player1 & player2 before calling the class incase of setting them null
        public Player player1 = new Player("X", true);
        public Player player2 = new Player("O", false);
        private bool gameOver = false;


        public GameWindow()
        {
            InitializeComponent();
            // when an instance of class is created run the condition window first
            ConditionWindow conditionWindow = new ConditionWindow();
            conditionWindow.ShowDialog();

            // set local player data into recived data from user input in condition window
            this.player1.PlayerMarker = conditionWindow.player1.PlayerMarker;
            this.player1.PlayerTurn = conditionWindow.player1.PlayerTurn;
            this.player1.PlayerWins = 0;

            this.player2.PlayerMarker = conditionWindow.player2.PlayerMarker;
            this.player2.PlayerTurn = conditionWindow.player2.PlayerTurn;
            this.player2.PlayerWins = 0;

            richTextBoxPlayerMovesConsole.Text += "Game Started\n";
            richTextBoxPlayerMovesConsole.Text += "Player 1 Marker " + player1.PlayerMarker + "\n";
            richTextBoxPlayerMovesConsole.Text += "Player 2 Marker " + player2.PlayerMarker + "\n";

            if (player1.PlayerTurn)
            {
                richTextBoxPlayerMovesConsole.Text += "Player 1 starts \n";
            }
            else {
                richTextBoxPlayerMovesConsole.Text += "Player 2 starts \n";
            }
            this.ShowDialog(); // shows the game window after setting the Player instances data

        }

        // sets all tic tac arraies to empty string for new game
        private void restartArray() {
            gameOver = false;
            labelPlayerWinsCount1.Text = Convert.ToString(player1.PlayerWins);
            labelPlayerWinsCount2.Text = Convert.ToString(player2.PlayerWins);
            buttonArray1.Text = "";
            buttonArray2.Text = "";
            buttonArray3.Text = "";
            buttonArray4.Text = "";
            buttonArray5.Text = "";
            buttonArray6.Text = "";
            buttonArray7.Text = "";
            buttonArray8.Text = "";
            buttonArray9.Text = "";
        }

        // start a new game
        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // play again with out changing current wins
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            restartArray();
            richTextBoxPlayerMovesConsole.Text += "Another Game Started\n";
            //move the caret to the end of the text
            richTextBoxPlayerMovesConsole.SelectionStart = richTextBoxPlayerMovesConsole.TextLength;
            //scroll to the caret
            richTextBoxPlayerMovesConsole.ScrollToCaret();
        }

        private void richTextBoxPlayerMovesConsole_TextChanged(object sender, EventArgs e)
        {
        }

        // check winning condition if met and to which player is the winning condition
        private void checkWinner() {
            if (
                buttonArray1.Text != "" && buttonArray1.Text == buttonArray2.Text && buttonArray2.Text == buttonArray3.Text ||
                buttonArray4.Text != "" && buttonArray4.Text == buttonArray5.Text && buttonArray5.Text == buttonArray6.Text ||
                buttonArray7.Text != "" && buttonArray7.Text == buttonArray8.Text && buttonArray8.Text == buttonArray9.Text ||
                buttonArray1.Text != "" && buttonArray1.Text == buttonArray4.Text && buttonArray4.Text == buttonArray7.Text ||
                buttonArray2.Text != "" && buttonArray2.Text == buttonArray5.Text && buttonArray5.Text == buttonArray8.Text ||
                buttonArray3.Text != "" && buttonArray3.Text == buttonArray6.Text && buttonArray2.Text == buttonArray9.Text ||
                buttonArray1.Text != "" && buttonArray1.Text == buttonArray5.Text && buttonArray5.Text == buttonArray9.Text ||
                buttonArray3.Text != "" && buttonArray3.Text == buttonArray5.Text && buttonArray5.Text == buttonArray7.Text
                ) {
                    if (buttonArray1.Text == player1.PlayerMarker && !gameOver)
                    {
                        player1.PlayerWins += 1;
                        labelPlayerWinsCount1.Text = Convert.ToString(player1.PlayerWins);
                        richTextBoxPlayerMovesConsole.Text += "Player 1 Wins!\n";
                        MessageBox.Show("Player 1 Wins!");
                    }
                    else if (!gameOver)
                    {
                        player2.PlayerWins += 1;
                        labelPlayerWinsCount2.Text = Convert.ToString(player2.PlayerWins);
                        richTextBoxPlayerMovesConsole.Text += "Player 2 Wins!\n";
                        MessageBox.Show("Player 2 Wins!");
                    }
                    gameOver = true;
            }

            //move the caret to the end of the text
            richTextBoxPlayerMovesConsole.SelectionStart = richTextBoxPlayerMovesConsole.TextLength;
            //scroll to the caret
            richTextBoxPlayerMovesConsole.ScrollToCaret();
        }

        // check what happens when button is clicked on tic tac array and return the clickers Marker if valid
        private string buttonClick()
        {
            if (player1.PlayerTurn && !gameOver)
            {
                player1.PlayerTurn = false;
                player2.PlayerTurn = true;
                richTextBoxPlayerMovesConsole.Text += "Players 2 turn\n";
                return player1.PlayerMarker;
            }
            else if (player2.PlayerTurn && !gameOver)
            {
                player2.PlayerTurn = false;
                player1.PlayerTurn = true;
                richTextBoxPlayerMovesConsole.Text += "Players 1 turn\n";
                return player2.PlayerMarker;
            }
            return "";
        }

        // tic tac toe button array buttons
        private void buttonArray1_Click(object sender, EventArgs e)
        {
            if (this.buttonArray1.Text == "")
            {
                this.buttonArray1.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray2_Click(object sender, EventArgs e)
        {

            if (this.buttonArray2.Text == "") {
                this.buttonArray2.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray3_Click(object sender, EventArgs e)
        {
            if (this.buttonArray3.Text == "")
            {
                this.buttonArray3.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray4_Click(object sender, EventArgs e)
        {
            if (this.buttonArray4.Text == "")
            {
                this.buttonArray4.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray5_Click(object sender, EventArgs e)
        {
            if (this.buttonArray5.Text == "")
            {
                this.buttonArray5.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray6_Click(object sender, EventArgs e)
        {
            if (this.buttonArray6.Text == "")
            {
                this.buttonArray6.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray7_Click(object sender, EventArgs e)
        {
            if (this.buttonArray7.Text == "")
            {
                this.buttonArray7.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray8_Click(object sender, EventArgs e)
        {
            if (this.buttonArray8.Text == "")
            {
                this.buttonArray8.Text = buttonClick();
            }
            checkWinner();
        }

        private void buttonArray9_Click(object sender, EventArgs e)
        {
            if (this.buttonArray9.Text == "")
            {
                this.buttonArray9.Text = buttonClick();
            }
            checkWinner();
        }
      
    }
}
