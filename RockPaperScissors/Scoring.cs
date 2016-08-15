using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Scoring
    {
        string selectionOne;
        string selectionTwo;

        int round;

        Player playerOne;
        Player playerTwo;

        public Scoring()
        {
            round = 0;
        }

        public void ScoreCount()
        {
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
                    selectionTwo = playerTwo.TakeTurn();
                }
            }
        }
    }
}
