using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_1_tic_tac
{

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            GameWindow gameWindow = new GameWindow();     

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