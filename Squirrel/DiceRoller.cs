using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class DiceRoller
    {
        private Random _random; // _ kennzeichnet oft private Variablen

        public DiceRoller()
        {
            _random = new Random();
        }
        public int RollDice()
        {
            var result = _random.Next(1, 7);
            return result;
        }
    }
}
