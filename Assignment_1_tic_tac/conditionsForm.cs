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
    public partial class conditionsForm : Form
    {
        public conditionsForm()
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
            // logic?
        }

        // } end of Make sure one player has uniue marker
    }
}
