using SnakesAndLadders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace SnakesAndLaddersNUnit
{
    public class BoardTest
    {
        private Board _board;

        [SetUp]
        public void Setup() 
        {
            _board = new Board(4);
        }

        [Test]
        public void getEndposition_shouldReturn15()
        {
            _board = new Board(4);
            var result = _board.getEndposition();
            result.Should().Be(15);
        }
    }
}
