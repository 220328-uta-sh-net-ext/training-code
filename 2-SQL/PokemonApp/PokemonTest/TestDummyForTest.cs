using PokemonBL;
using Xunit;

namespace PokemonTest;

public class TestDummyForTest
{
    //Arrange
    DummyForTest obj = new();

    [Fact]
    public void TestAdd()
    {
        // note that comparing floating-point numbers for exact equality is not really reliable
        double a = 10.5, b = 20.4, expected = 30.9;
        double actual = obj.Add(a, b);
        Assert.Equal(expected, actual);
        Assert.Equal(10 + 20, obj.Add(new double[] { 10, 20 }));//tested for int values
        Assert.Equal(10.4 + 20.5, obj.Add(new double[] { 10.4, 20.5 }));// tested for decimals
        Assert.Equal(2 + 3 + 4, obj.Add(new double[] { 2, 3, 4 }));// testing for adding 3 numbers
        Assert.Equal(15, obj.Add(new double[] { 1, 2, 3, 4, 5 }));
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    public void TestIsOdd(int value)
    {
        Assert.True(obj.IsOdd(value));
    }
}
