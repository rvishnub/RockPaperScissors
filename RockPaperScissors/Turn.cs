using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Turn
    {

        string hand;
        string selection;
        int score;
        int randomNumber;

        Player player;

        List<string> Hands = new List<string>() { "ROCK", "PAPER", "SCISSORS" };

        public Turn()
        {
            this.hand = "";
            this.score = 0;
        }

        public void TakeTurn()
        {
            Console.WriteLine();
            Console.WriteLine("What is your selection, {0}? Rock, Paper or Scissors?", player);
            Console.WriteLine();
            selection = Console.ReadLine();
            this.hand = selection.ToUpper();
            
        }

        public int GetRandomNumber()
        {
            Random random = new Random();
            randomNumber = random.Next(0, 2);
            return randomNumber;
        }

        public string ComputerTakeTurn()
        {
            selection = Hands[randomNumber];
            return selection;
        }
     
        public string GetSelection()
        {
            Console.WriteLine("{0}'s selection for this round was {1}.", player, this.hand);
            Console.WriteLine();
            return this.hand;
        }
        public void AddToScore()
        {
            this.score = +1;
        }


        public void RepeatSelection()
            {
            while (!Hands.Contains(selection))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please try again:  rock, paper or scissors.");
                    Console.WriteLine();
                    selection = Console.ReadLine();
                    selection = selection.ToUpper();
                }

                Console.WriteLine();
                Console.WriteLine("Thank you, {0}, your choice is {1}.", player, selection);
                selection = selection.ToUpper();
            }

        public int GetScore()
        {
            return this.score;
        }
    }
}
