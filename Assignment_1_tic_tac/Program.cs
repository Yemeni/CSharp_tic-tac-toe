using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_1_tic_tac
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainForm());
            //Application.Run(new ConditionsForm());
            ConditionsForm cForm = new ConditionsForm();
            cForm.ShowDialog();
            MainForm mForm = new MainForm();
            mForm.setPlayerMarker1(cForm.passComboBoxPlayerMarker1);
            mForm.setPlayerMarker2(cForm.passComboBoxPlayerMarker2);
            mForm.setPlayerStart(cForm.passCheckBoxPlayerStart1, cForm.passCheckBoxPlayerStart1);
            mForm.ShowDialog();



        }
    }
}


/* 
 * Class Condition
 *  player 1 Marker
 *  player 2 Marker
 *  player 1 isStart
 *  player 2 isStart
 *  Player 2 isHuman
 *  
 * Class Game
 *  player 1 Marker
 *  player 2 Marker
 *  player Start
 *  player 1 wins
 *  player 2 wins
 *  player turn
 *  Array button
*/