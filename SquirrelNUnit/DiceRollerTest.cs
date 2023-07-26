using FluentAssertions;
using SnakesAndLadders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersNUnit
{
    public class DiceRollerTest
    {
        private DiceRoller _diceRoller;

        [SetUp]
        public void Setup()
        {
            _diceRoller = new DiceRoller();
        }

        [Test]
        public void RollDice_returnsAllNumbers()
        {
            var results = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                var current = _diceRoller.RollDice();

                results.Add(current);
            }

            results.Should().Contain(1);
            results.Should().Contain(2);
            results.Should().Contain(3);
            results.Should().Contain(4);
            results.Should().Contain(5);
            results.Should().Contain(6);
        }

        [Test]
        public void RollDice_returnsInRange()
        {
            var result = _diceRoller.RollDice();
            result.Should().BeInRange(1, 6);
            result.Should().BeOfType(typeof(int));
        }
    }
}
