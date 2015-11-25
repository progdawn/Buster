using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buster
{
    //controlling class
    class Controller
    {
        Player user = new Player(); //user's player object
        Player cpu = new Player(); //computer's player object
        Output uiOutput = new Output();
        UserInput uiInput = new UserInput();
        Dice theDice = new Dice();
        Sounds music = new Sounds();

        private int maxTurns = 5; //max turns allowed. Considered making this part of a "Dealer" type class
        private int currentTurn = 0; //current turn

        public Controller()
        {

        }

        //main game cycle
        public void MainGame()
        {
            theDice.DiceRoll();
            do
            {
                uiOutput.PreGameHeader(user.PlayerName, cpu.PlayerName);
                while ((currentTurn < maxTurns) && (user.PlayerMove != "Q" && user.PlayerMove != "q"))
                {
                    ComputerRoll();
                    UserRoll();
                    uiOutput.Header(user.PlayerName, cpu.PlayerName, user.TotalScore, cpu.TotalScore);
                    currentTurn++;
                    GetNextMove();
                }
                EndOfGame();
                ResetAllTheThings();
            } while (user.NewGame == "Y" || user.NewGame == "y");

        }

        //computer's roll
        public void ComputerRoll()
        {
            if(cpu.TotalScore <= user.TotalScore)
            {
                cpu.TotalScore = 0;
                music.CpuRolling();
                theDice.DiceRoll();
                AddCpuScore();
                uiOutput.PrintRoll(cpu.PlayerName, theDice.TheseDice);
            }

            else
            {
                music.Skipped();
                uiOutput.Skipped(cpu.PlayerName);
            }
        }

        //user's roll
        public void UserRoll()
        {
            if(user.PlayerMove == "R" || user.PlayerMove == "r")
            {
                user.TotalScore = 0;
                music.UserRolling();
                theDice.DiceRoll();
                AddUserScore();
                uiOutput.PrintRoll(user.PlayerName, theDice.TheseDice);
                uiOutput.WhiteSpace();
            }

            else if (user.PlayerMove == "P" || user.PlayerMove == "p")
            {
                music.Skipped();
                uiOutput.Skipped(user.PlayerName);
            }
            else
            {
                music.Quit();
                uiOutput.Quit(user.PlayerName);
            }
        }

        //gets both players' names
        public void IntialSetup()
        {
            user.PlayerName = uiInput.EnterName();
            cpu.PlayerName = uiInput.EnterOpponentName();
        }

        //adds users dice
        public void AddUserScore()
        {
            for (int die = 0; die < theDice.NumberOfDice; die++)
            {
                user.TotalScore += theDice.TheseDice[die];
            }
        }

        //adds computers dice
        public void AddCpuScore()
        {
            for (int die = 0; die < theDice.NumberOfDice; die++)
            {
                cpu.TotalScore += theDice.TheseDice[die];
            }
        }

        //report for the end of the game
        public void EndOfGame()
        {
            uiOutput.FinalReport(user.PlayerName, cpu.PlayerName, user.TotalScore, cpu.TotalScore);

            if (user.TotalScore > cpu.TotalScore)
            {
                uiOutput.SomeoneWins(user.PlayerName);
                music.UserWon();
            }
            else if (user.TotalScore < cpu.TotalScore)
            {
                uiOutput.SomeoneWins(cpu.PlayerName);
                music.UserLoss();
            }

            else
            {
                uiOutput.TiedGame();
                music.Tied();
            }

            user.NewGame = uiInput.NewGame();
        }

        //gets the next move from the user
        public void GetNextMove()
        {
            if (currentTurn < maxTurns)
            {
                user.PlayerMove = uiInput.NextMove();
            }
        }

        //resets values for new game
        public void ResetAllTheThings()
        {
            currentTurn = 0;
            user.TotalScore = 0;
            cpu.TotalScore = 0;
            user.PlayerMove = "R";
        }
    }
}
