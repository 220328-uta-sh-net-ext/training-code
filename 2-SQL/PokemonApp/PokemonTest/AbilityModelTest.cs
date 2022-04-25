using PokemonModels;
using Xunit;

namespace PokemonTest
{
    public class AbilityModelTest
    {
        /// <summary>
        /// Checks the validation for PP property for valid data
        /// </summary>
        /// [Fact] is a data annotation in C# and all it means is it will tell the compiler that this specific method is a unit test
        [Fact]
        public void PPShouldBevalidData()
        {
            //Arrange
            Ability ability = new Ability();
            int validPP = 10;
            //Act
            ability.PP=validPP;
            //Assert
            Assert.NotNull(ability.PP);//checks that the property is not null meaning we did set data in this property
            Assert.Equal(validPP, ability.PP); //checks if the property does indeed hold the same value as what we set it as
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-120)]
        [InlineData(-123445)]
        public void PPShouldSetValidData(int p_invalidData)
        {
            //Arrange
            Ability ab=new Ability();

            //Assert
            Assert.Throws<System.Exception>(
                ()=>ab.PP=p_invalidData
                );
        }
    }
}
