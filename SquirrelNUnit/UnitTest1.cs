using FluentAssertions;

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
        public void Move_ShouldReturnExpectedField(int position, int steps, int expected) // statischer Test
        {
            var result = Move(position, steps);
            result.Should().Be(expected);
        }

        [Test]
        public void Move_toTheEnd()
        {
            var result = Move(14, 5);
            result.Should().Be(getEndposition()); //endposition is 15
        }

        [Test]
        public void RollTheDice_returnsInRange()
        {
            var result = RollTheDice();
            result.Should().BeInRange(1, 6);
        }

        public int RollTheDice()
        {
            return 0;
        }

        public int Move(int position, int steps)
        {
            int returnValue = position + steps;
            if(returnValue > getEndposition())
            {
                returnValue = getEndposition();
            }
            return returnValue;
        }

        public int getEndposition()
        {
            return 15;
        }


    }
}