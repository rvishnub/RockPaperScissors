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
        public string selectionOne;
        public string selectionTwo;

        Player playerOne;
        Player playerTwo;


        public Selection()
        {

        }

        public void JudgeSelection()
        {
            if (selectionOne == selectionTwo)
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
                switch (selectionOne)
                {
                    case "ROCK":
                        {
                            if (selectionTwo == "PAPER")
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
                round += 1;
            }
        }
    }
}
