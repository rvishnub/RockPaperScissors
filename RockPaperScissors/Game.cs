using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        public int round;
        public string nameOne;
        public string nameTwo;

        Player playerOne;
        Player playerTwo;
        public string selectionOne;
        public string selectionTwo;

        public Game()
        {
            this.playerOne = new Player();
            this.playerTwo = new Player();
        }

        public void RunGame()
        {
            this.nameOne = this.playerOne.GetName(this.playerOne);
            this.nameTwo = this.playerTwo.GetName(this.playerTwo);
            Console.WriteLine("Welcome, {0}, {1}!!", this.nameOne, this.nameTwo);
            Console.WriteLine();
            Console.WriteLine();
            round = 0;

            while (round < 3)
            {
                if (playerOne.score == 2)
                {
                    break;
                }
                else if (playerTwo.score == 2)
                {
                    break;
                }

                else
                {
                    Turn turn = new Turn();
                    selectionOne = turn.TakeTurn(playerOne);
                    selectionTwo = turn.ComputerTakeTurn(playerTwo);
                    Selection selection = new Selection(selectionOne, selectionTwo);
                    selection.JudgeSelection();
                    round += 1;

                }

            }


            Console.WriteLine();
            playerOne.GetWinner();
            Console.WriteLine();

            playerTwo.GetWinner();
            Console.ReadLine();

        }

    }

}