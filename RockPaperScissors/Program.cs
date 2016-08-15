using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, players, to Rock-Paper-Scissors!");
            Console.WriteLine();


            Game game = new Game();
                game.RunGame();

            Console.WriteLine("Thanks for playing!");
        }
    }
}
