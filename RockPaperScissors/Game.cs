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
        public string selectionOne;
        public string selectionTwo;

        Player playerOne;
        Player playerTwo;

        public Game()
        {
            this.playerOne = new Player();
            this.playerTwo = new Player();
        }

        public void RunGame()
        {
            playerOne.name = playerOne.GetName();
            playerTwo.name = playerTwo.GetName();
            Console.WriteLine();

            Console.WriteLine("Welcome, {0}, {1}!!", playerOne.name, playerTwo.name);
            Console.WriteLine();
            Console.WriteLine();

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
                    selectionOne = playerOne.TakeTurn();
                    selectionTwo = playerTwo.ComputerTakeTurn();
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