using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Buster
{
    //the dice object
    //units are set to static, since the dice stay the same between users. It's only their states that change
    class Dice
    {
        private static int numberOfDice = 5; //the number of dice the user can roll
        private static int[] theseDice = new int[numberOfDice]; //the array of dice that will be rolled
        private static int die = 0; //value of one die
        private static Random dieRoll = new Random((int)DateTime.Now.Ticks); //instantiates random class

        public Dice()
        {

        }

        public int Die
        {
            get { return die; }
            set { die = value; }
        }

        public int NumberOfDice
        {
            get { return numberOfDice; }
        }

        public int[] TheseDice
        {
            get { return theseDice; }
            set { theseDice = value; }
        }

        //cycles through dieRoll array, filling it with values for each die
        public void DiceRoll()
        {
            for (int currentDie = 0; currentDie < numberOfDice; currentDie++)
            {
                Thread.Sleep(40); //someone suggested this was a way of making numbers more random
                die = dieRoll.Next(1, 6);
                theseDice[currentDie] = die;
            }
        }

    }
}
