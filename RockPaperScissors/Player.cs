using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string name;
        public string selection;
        public string player;
        public int score;

        public Player()
        {
            this.player = name;
            this.selection = "";
        }


        public string GetName()
        {
            Console.WriteLine("What is your name, new Player?");
            Console.WriteLine();
            this.player = Console.ReadLine();
            return this.player;

        }

        public string SayName()
        {
            return this.player;
        }

        public void GetWinner()
        {
            if (score > 1)
            {
                Console.WriteLine();
                Console.WriteLine("You win, {0}!  You won {1} games!", player, score);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, {0}, you lose.", player);
            }
        }

    }
}


