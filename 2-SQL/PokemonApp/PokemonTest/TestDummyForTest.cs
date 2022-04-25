using PokemonBL;
using Xunit;

namespace PokemonTest
{
    public class TestDummyForTest
    {
        //Arrange
        DummyForTest obj = new DummyForTest();
        //Facts are tests which are always true. They test invariant conditions.
        [Fact]
        public void TestAdd()
        {
            double a = 10.5, b = 20.4, c = 5.6, expected = 30.9;
            //Act
            var actual = obj.Add(a, b);
            //Assert
            Assert.Equal(10 + 20, obj.Add(10 + 20));//tested for int values
            Assert.Equal(10.4 + 20.5, obj.Add(10.4 + 20.5));// tested for decimals
            Assert.Equal(2 + 3 + 4, obj.Add(2 + 3 + 4));// testing for adding 3 numbers
            Assert.Equal(15, obj.Add(1, 2, 3, 4, 5));
        }

        //Theories are tests which are only true for a particular set of data.
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void TestIsOdd(int value)
        {
            Assert.True(obj.IsOdd(value));
        }
    }
}