using FluentAssertions;
using SnakesAndLadders;

namespace SquirrelNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 3, 3)]
        [TestCase(3, 4, 7)]
        [TestCase(4, 5, 9)]
        [TestCase(6, 6, 12)]
        [TestCase(6, 2, 8)]
        [TestCase(2, 1, 3)]
        public void Move_returnsExpectedField(int position, int steps, int expected) // statischer Test
        {
            var result = PieceMover.Move(position, steps);
            result.Should().Be(expected);
        }

        [Test]
        public void Move_toTheEnd()
        {
            var result = PieceMover.Move(14, 5);
            result.Should().Be(PieceMover.getEndposition()); //endposition is 15
        }

        [Test]
        public void RollDice_returnsInRange()
        {
            var diceRoller = new DiceRoller();
            var result = diceRoller.RollDice();
            result.Should().BeInRange(1, 6);
            result.Should().BeOfType(typeof(int));
        }

        [Test]
        public void RollDice_returnsAllNumbers()
        {
            var results = new List<int>();
            //int[] array = new int[6]; 

            for(int i = 0; i < 100; i++)
            {
                var diceRoller = new DiceRoller();
                var current = diceRoller.RollDice();
                
                results.Add(current);
                //array[current + 1] += 1;
            }

            results.Should().Contain(1);
            results.Should().Contain(2);
            results.Should().Contain(3);
            results.Should().Contain(4);
            results.Should().Contain(5);
            results.Should().Contain(6);
            //for(int i = 0; i<6; i++)
            //{
            //    System.Console.WriteLine(array[i]);
            //}
            
        }

        [Test]
        public void RollDiceAndMove_returnsInRange()
        {
            var result = PieceMover.RollDiceAndMove(0);
            result.Should().BeInRange(1, 6);
        }


        
    }

    
}