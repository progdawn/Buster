using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Buster
{
    //class used for both the user and the computer
    class Player
    {
        private string playerName = "asdf"; //player's name
        private string playerMove = "R"; //re-roll, pass, or quit
        private int totalScore = 0; //stores value of current roll
        private string newGame = "Y"; //checks to see if user wants to play again

        public Player()
        {

        }


        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public string PlayerMove
        {
            get { return playerMove; }
            set { playerMove = value; }
        }

        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public string NewGame
        {
            get { return newGame; }
            set { newGame = value; }
        }
    }
}
