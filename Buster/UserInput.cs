using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buster
{
    //class for user input only
    class UserInput
    {
        public UserInput()
        {

        }

        //get user name
        public string EnterName()
        {
            string yourName;

            Console.Write("Please enter your name >> ");
            yourName = Console.ReadLine();
            return yourName;
        }

        //get computer's name
        public string EnterOpponentName()
        {
            string opponentName;
            Console.Write("Please enter your opponent's name >> ");
            opponentName = Console.ReadLine();
            Console.Write("Press any key to begin playing >> ");
            Console.ReadKey();
            Console.Clear();
            return opponentName;
        }

        //get the next move, roll, pass, or quit
        public string NextMove()
        {
            string whatNext;
            Console.Write("\nPress \"R\" to roll, \"P\" to pass, or \"Q\" to quit >> ");
            whatNext = Console.ReadLine();
            Console.WriteLine();
            return whatNext;
        }

        //gets new game or quit game from user
        public string NewGame()
        {
            string newGame;
            Console.Write("Press \"Y\" to play again, or \"Q\" to quit >> ");
            newGame = Console.ReadLine();
            Console.Clear();
            return newGame;
        }
    }
}
