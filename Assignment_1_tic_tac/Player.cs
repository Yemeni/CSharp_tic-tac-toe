using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_1_tic_tac
{
    public class Player
    {
        // member variables
        private string playerMarker;
        private int playerWins;
        private bool playerTurn;

        // constructor
        public Player(string marker, bool turn) {
            this.PlayerMarker = marker;
            this.PlayerTurn = turn;
        }

        // setters & getters
        public string PlayerMarker 
        {
            get { return this.playerMarker; }
            set { this.playerMarker = value; }
        }

        public int PlayerWins
        {
            get { return this.playerWins; }
            set { this.playerWins = value; }
        }

        public bool PlayerTurn
        {
            get { return this.playerTurn; }
            set { this.playerTurn = value; }
        }


    }
}


