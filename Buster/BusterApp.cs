using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buster
{
    class BusterApp
    {
        static void Main(string[] args)
        {
            Admin wizardry = new Admin();
            Controller game = new Controller();

            wizardry.ConsoleSetup(); //sets up console size, title, and colors
            wizardry.Intro(); //introduction to application
            game.IntialSetup(); //allows user to enter their name and cpu name. Not part of loop, to maintain these values for each game
            game.MainGame(); //the game itself
            wizardry.Goodbye(); //shutdown screen
        }
    }
}
