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
    
    public partial class MainForm : Form
    {
        private string playerMarker1;
        private string playerMarker2;
        private int playerWins1;
        private int playerWins2;
        private int playerTurn;
        private string[] buttonLabel = new string[10];

        // sets
        // player marker 1
        public void setPlayerMarker1(string playerMarker){
            playerMarker1 = playerMarker;
        }

        // player makrer 2
        public void setPlayerMarker2(string playerMarker)
        {
            playerMarker2 = playerMarker;
        }

        // starting player
        public void setPlayerStart(bool player1, bool player2) {
            if (player1)
            {
                playerTurn = 1;
            }
            else {
                playerTurn = 2;
            }
        }

        public string setButtonLabel() {
            if (playerTurn == 1)
            {
                return playerMarker1;
            }
            else {
                return playerMarker2;
            }
        }

        // end of sets

        // draw game

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            richTextBoxPlayerMovesConsole.Text += "Welcome to tic tac toe\n";
            richTextBoxPlayerMovesConsole.Text += "Player 1 Marker : " + playerMarker1 + "\n";
            richTextBoxPlayerMovesConsole.Text += "Player 2 Marker : " + playerMarker2 + "\n";
            richTextBoxPlayerMovesConsole.Text += "Starting player : " + playerTurn + "\n";

            // making string in all buttons into empty
            for (int i = 0; i <= 10; i++) {
                buttonLabel[i] = "";
            }
            

        }

        private void richTextBoxPlayerMovesConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonArray1_Click(object sender, EventArgs e)
        {
            if (buttonLabel[1] == "")
            {
                buttonArray1.Text = setButtonLabel();
            }
            else
                buttonArray1.Text = "wtf";
        }






       
    }
}
