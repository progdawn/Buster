using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Buster
{
    class Output
    {
        //output only. User input is in another class
        public Output()
        {

        }

        //prints the dice roll
        public void PrintRoll(string name, int[] diceRoll)
        {
            Console.Write("{0} rolled\t", name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("{0}", string.Join(" | ", diceRoll));
            Console.ResetColor();
            Console.Write("\t\t");
            Lazy();
        }

        //if player chose to skip, print this
        public void Skipped(string name)
        {
            Console.Write("{0} chose to ", name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("skip");
            Console.ResetColor();
            Console.Write(" this turn\t\t\t");
            Lazy();
        }

        //if player chose to quit, print this
        public void Quit(string name)
        {
            Console.Write("{0} has chose to quit\n", name);
            Lazy();
        }

        //total scores are always at the top of the screen. This was fun!
        //Since there's no score before the first roll, this is just generic text
        public void PreGameHeader(string userName, string cpuName)
        {
            WhiteSpace();
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("{0} rolling\t\t\t\t\t{1} rolling\t\t\t", cpuName, userName);
            Console.ResetColor();
            Console.SetCursorPosition(left, top);
        }

        //updates the score at the top with each roll
        public void Header(string userName, string cpuName, int userScore, int cpuScore)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("{0}'s score: {1}\t\t\t\t\t{2}'s score: {3}", cpuName, cpuScore, userName, userScore);
            Console.ResetColor();
            Console.SetCursorPosition(left, top);
        }

        //prints report once five turns have passed, or user chose to quit
        public void FinalReport(string userName, string cpuName, int userScore, int cpuScore)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n{0} finished with a score of {1}", cpuName, cpuScore);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t{0} finished with a score of {1}", userName, userScore);
            Console.ResetColor();
        }

        //prints the winner
        public void SomeoneWins(string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t\t\t\t{0} won!\n", name);
            Console.ResetColor();
        }

        //shortcut for thread.sleep
        public void Lazy()
        {
            Thread.Sleep(500);
        }

        //shortcut for whitespace
        public void WhiteSpace()
        {
            Console.WriteLine();
        }

        //print this for a tied game
        public void TiedGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\t\t\tIt's a tie!");
            Console.ResetColor();
        }
    }
}
