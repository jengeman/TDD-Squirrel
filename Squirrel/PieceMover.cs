using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class PieceMover
    {
        public static int RollDiceAndMove(int position)
        {
            var diceRoller = new DiceRoller();
            var random = diceRoller.RollDice();
            var newPosition = Move(position, random);

            return newPosition;
        }

        public static int Move(int position, int steps)
        {
            int returnValue = position + steps;
            if (returnValue > getEndposition())
            {
                returnValue = getEndposition();
            }
            return returnValue;
        }

        public static int getEndposition()
        {
            return 15;
        }
    }
}
