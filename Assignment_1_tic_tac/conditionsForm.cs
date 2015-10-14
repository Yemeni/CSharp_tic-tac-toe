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
    public partial class ConditionsForm : Form
    {
        public string passComboBoxPlayerMarker1;
        public string passComboBoxPlayerMarker2;
        public bool passCheckBoxPlayerStart1;
        public bool passCheckBoxPlayerStart2;

        public ConditionsForm()
        {
            InitializeComponent();
            comboBoxPlayerMarker1.SelectedIndex = 0; // initializing default comboBoxPlayerMarker1 to X
            comboBoxPlayerMarker2.SelectedIndex = 1; // initializing default comboBoxPlayerMarker1 to O
        }

        // Make sure one player starts first {
        // checks if checkbox got changed
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

        // checks if checkbox got changed
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
        // } end of Make sure one player starts first

        // Make sure one player has unique marker {
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

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            // validatoin
            if ((comboBoxPlayerMarker1.SelectedIndex != comboBoxPlayerMarker2.SelectedIndex) &&
                (checkBoxPlayerStart1 != checkBoxPlayerStart2))
            {
                passComboBoxPlayerMarker1 = comboBoxPlayerMarker1.Text;
                passComboBoxPlayerMarker2 = comboBoxPlayerMarker2.Text;
                passCheckBoxPlayerStart1 = checkBoxPlayerStart1.Checked;
                passCheckBoxPlayerStart2 = checkBoxPlayerStart2.Checked;
                this.Close();
            }
        }

        private void labelConditionsIntroduction_Click(object sender, EventArgs e)
        {

        }





        // } end of Make sure one player has uniue marker
    }
}
