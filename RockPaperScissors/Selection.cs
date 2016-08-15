using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Selection
    {

        public int round;
        public string selection;
        public string otherSelection;

        public string selectionOne;
        public string selectionTwo;
        Player playerOne;
        Player playerTwo;


        public Selection()
        {
            selection = this.selectionOne;
            otherSelection = this.selectionTwo;
        }

        public void JudgeSelection()
        {
            if (selection == otherSelection)
            {
                Console.WriteLine();
                Console.WriteLine("You have made the same selection:  {0}.  Try again.", selectionOne);
                Console.WriteLine();

            }

            //else if (playerOne.score ==0  playerTwo.score == 0)
            //{
            //    break;
            //}
            else
            {
                switch (selection)
                {
                    case "ROCK":
                        if (otherSelection == "PAPER")
                        {
                            playerTwo.score += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerTwo.name);
                            Console.WriteLine();
                        }
                        else
                        {
                            playerOne.score += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerOne.name);
                            Console.WriteLine();
                        }
                        break;

                    case "PAPER":
                        if (selectionTwo == "SCISSORS")
                        {
                            playerTwo.score += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerTwo.name);
                            Console.WriteLine();
                        }
                        else
                        {
                            playerOne.score += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerOne.name);
                            Console.WriteLine();
                        }
                        break;


                    case "SCISSORS":
                        if (selectionTwo == "ROCK")
                        {
                            playerTwo.score += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerTwo.name);
                            Console.WriteLine();

                        }
                        else
                        {
                            playerOne.score += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerOne.name);
                            Console.WriteLine();

                        }
                        break;
                }
            }
            round += 1;

        }
    }
}
