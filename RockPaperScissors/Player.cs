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
            player = "Player";
        }


        public string GetName(Player player)
        {
            Console.WriteLine("What is your name, Player?");
            Console.WriteLine();
            name = Console.ReadLine();
            return name;
        }

        public string SayName()
        {
            return name;
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


