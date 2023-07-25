using FluentAssertions;

namespace SquirrelNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Move_ShouldReturn5() // 5 da es ein statischer Test ist
        {
            var result = Move(0, 5);
            result.Should().Be(5);
        }
        [Test]
        public void Move_toTheEnd() 
        {
            int endposition = getEndposition(); //endposition is 16
            var result = Move(15, 5);
            result.Should().Be(16);
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
            return 16;
        }


    }
}