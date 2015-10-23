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
    public partial class ConditionWindow : Form
    {
        public Player player1 = new Player("X", true);
        public Player player2 = new Player("O", false);


        public ConditionWindow()
        {
            InitializeComponent();
            
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if ((comboBoxPlayerMarker1.SelectedIndex != comboBoxPlayerMarker2.SelectedIndex) &&
                (checkBoxPlayerStart1 != checkBoxPlayerStart2))
            {

                player1.PlayerMarker = comboBoxPlayerMarker1.Text;
                player2.PlayerMarker = comboBoxPlayerMarker2.Text;

                player1.PlayerTurn = checkBoxPlayerStart1.Checked;
                player2.PlayerTurn = checkBoxPlayerStart2.Checked;

                this.Close();
               
            }
        }

        private void checkBoxPlayerStart1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayerStart1.Checked)
            {
                checkBoxPlayerStart2.Checked = false;
            }
            else
            {
                checkBoxPlayerStart2.Checked = true;
            }
        }

        private void checkBoxPlayerStart2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayerStart2.Checked)
            {
                checkBoxPlayerStart1.Checked = false;
            }
            else
            {
                checkBoxPlayerStart1.Checked = true;
            }
        }

        private void comboBoxPlayerMarker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int playerOneIndex = comboBoxPlayerMarker1.SelectedIndex;

            if (playerOneIndex == 0)
            {
                comboBoxPlayerMarker2.SelectedIndex = 1;
            }
            else
            {
                comboBoxPlayerMarker2.SelectedIndex = 0;
            }
        }

        private void comboBoxPlayerMarker2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int playerTwoIndex = comboBoxPlayerMarker2.SelectedIndex;

            if (playerTwoIndex == 0)
            {
                comboBoxPlayerMarker1.SelectedIndex = 1;
            }
            else
            {
                comboBoxPlayerMarker1.SelectedIndex = 0;
            }
        }





    }
}
