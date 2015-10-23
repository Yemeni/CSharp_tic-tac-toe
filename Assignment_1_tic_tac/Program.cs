/**
  * Simple tic tac toe game
  * @version 1.0
  * @author Yousef Al-Hadhrami <yhadhr@gmail.com>
*/

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
            GameWindow gameWindow = new GameWindow(); // Start main game class which automaticlly calls condition class on initliasation
        }
    }
}
