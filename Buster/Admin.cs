using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Buster
{
    //used for setting up the console, providing introduction, and exiting the application
    class Admin
    {
        //default constructor
        public Admin()
        {

        }

        //sets up console title, size, and colors
        public void ConsoleSetup()
        {
            Console.Title = "Buster"; //window title
            Console.SetWindowSize(110, 30); //window size, makes things easier to read
            Console.BackgroundColor = ConsoleColor.Black; //background color of console
            Console.ForegroundColor = ConsoleColor.Yellow; //text color
            Console.Clear();
        }

        //introduction and instructions for the application
        public void Intro()
        {
            Console.Beep(330, 500);
            Console.WriteLine("Welcome to Buster!");
            Lazy();
            Console.WriteLine("In this game, you and the computer will take turns rolling five dice.");
            Lazy();
            Console.WriteLine("The dice are added together for a score.");
            Lazy();
            Console.WriteLine("After the scores are calculated, you can choose to roll again for a new score, or pass.");
            Lazy();
            Console.WriteLine("If the computer has a higher score, they'll automatically pass.");
            Lazy();
            Console.WriteLine("After five turns, the winner will be chosen based on the highest score.");
            Lazy();
            Console.Write("Press any key to play >> ");
            Console.ReadKey();
            Console.Clear();
        }

        //provides a way to exit the application
        public void Goodbye()
        {
            Console.Beep(330, 200);
            Console.WriteLine("Thanks for playing Buster");
            Lazy();
            Console.Write("Shutting down");
            Lazy();
            Console.Write(".");
            Lazy();
            Console.Write(".");
            Lazy();
            Console.Write(".");
        }

        public void Lazy()
        {
            Thread.Sleep(500);
        }
    }
}
