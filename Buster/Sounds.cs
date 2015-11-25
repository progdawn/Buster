using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buster
{
    //sounds for the game
    class Sounds
    {
        public Sounds()
        {

        }

        //sound for computer rolling
        public void CpuRolling()
        {
            Console.Beep(500, 100);
            Console.Beep(400, 100);
            Console.Beep(300, 100);
        }

        //sound for user rolling
        public void UserRolling()
        {
            Console.Beep(300, 100);
            Console.Beep(400, 100);
            Console.Beep(500, 100);
        }

        //if either player skipped
        public void Skipped()
        {
            Console.Beep(400, 100);
            Console.Beep(400, 100);
            Console.Beep(400, 100);
        }

        //if user quit
        public void Quit()
        {
            Console.Beep(500, 100);
            Console.Beep(500, 100);
            Console.Beep(500, 100);
        }

        //if user won
        public void UserWon()
        {
            Console.Beep(423, 300);
            Console.Beep(587, 300);
            Console.Beep(361, 300);
            Console.Beep(392, 600);
        }

        //if user loss
        public void UserLoss()
        {
            Console.Beep(423, 300);
            Console.Beep(387, 300);
            Console.Beep(261, 300);
            Console.Beep(192, 600);
        }

        //if both players tied
        public void Tied()
        {
            Console.Beep(400, 100);
            Console.Beep(300, 100);
            Console.Beep(400, 100);
            Console.Beep(200, 100);
        }
    }
}
