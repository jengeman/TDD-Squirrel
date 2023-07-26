using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class PieceMover
    {
        private IDiceRoller _diceRoller;
        private Board _board;

        public PieceMover(IDiceRoller diceRoller)
        {
            _diceRoller = diceRoller;
            _board = new Board(4);
        }

        public int RollDiceAndMove(int position)
        {
            var random = _diceRoller.RollDice();
            var newPosition = Move(position, random);

            return newPosition;
        }

        public int Move(int position, int steps)
        {
            int returnValue = position + steps;
            if (returnValue > _board.getEndposition())
            {
                returnValue = _board.getEndposition();
            }
            return returnValue;
        }

    }
}
