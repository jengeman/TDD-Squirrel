using FluentAssertions;
using SnakesAndLadders;
using FakeItEasy;

namespace SquirrelNUnit
{
    public class PieceMoverTest
    {
        private PieceMover _sut; // System under test --> spart Codezeilen
        private IDiceRoller _diceRoller;
        private Board _board;

        [SetUp]
        public void Setup()
        {
            _diceRoller = A.Fake<IDiceRoller>(); // durch das Paket "FakeItEasy"
            _board = new Board(4); 
            _sut = new PieceMover(_diceRoller, _board);
        }

        [TestCase(0, 3, 3)]
        [TestCase(3, 4, 7)]
        [TestCase(4, 5, 9)]
        [TestCase(6, 6, 12)]
        [TestCase(6, 2, 8)]
        [TestCase(2, 1, 3)]
        public void Move_returnsExpectedField(int position, int steps, int expected) // statischer Test
        {
            var result = _sut.Move(position, steps);
            result.Should().Be(expected);
        }

      


        //[Test] // Dieser Test ist mit dem fake RolleDice nicht mehr notwendig
        //public void RollDiceAndMove_returnsInRange()
        //{
        //    var result = _sut.RollDiceAndMove(0);
        //    result.Should().BeInRange(1, 6);
        //}

        [Test]
        public void RollDiceAndMove_returns4()
        {
            A.CallTo( () => _diceRoller.RollDice()).Returns(4); // da _diceRoller fake ist, gibt es hier wie gewollte eine 4 zurück
            var result = _sut.RollDiceAndMove(0);
            result.Should().Be(4);
        }

        [Test]
        public void Move_toTheEnd()
        {
            var result = _sut.Move(14, 5);
            result.Should().Be(_board.getEndposition()); //endposition is 15
        }
    }
}