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
        public int playerOnescore;
        public int playerTwoscore;

        Player playerOne;
        Player playerTwo;

        public Selection(string selection, string otherSelection)
        {
            selection = "Selection";
            otherSelection = "Other Selection";
        }

        public void JudgeSelection()
        {
            if (selection == otherSelection)
            {
                Console.WriteLine();
                Console.WriteLine("You have made the same selection:  {0}.  Try again.", selection);
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
                            playerTwoscore += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerTwo);
                            Console.WriteLine();
                        }
                        else
                        {
                            playerOnescore += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerOne);
                            Console.WriteLine();
                        }
                        break;

                    case "PAPER":
                        if (otherSelection == "SCISSORS")
                        {
                            playerTwoscore += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerTwo);
                            Console.WriteLine();
                        }
                        else
                        {
                            playerOnescore += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerOne);
                            Console.WriteLine();
                        }
                        break;


                    case "SCISSORS":
                        if (otherSelection == "ROCK")
                        {
                            playerTwoscore += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerTwo);
                            Console.WriteLine();

                        }
                        else
                        {
                            playerOnescore += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Score one for {0}!", playerOne);
                            Console.WriteLine();

                        }
                        break;
                }
            }
        }
    }
}
