using System;
using System.Linq;
using RestaurantReviews.Library.Models;
using Xunit;

namespace RestaurantReviews.Testing.Library.Models
{
    public class RestaurantTest
    {
        // the test class is instantiated again for each test, so it is safe to put common setup code
        // in the class constructor or members. this will be a new restaurant object for each test.
        // it's made readonly to satisfy static analysis warnings.
        readonly Restaurant restaurant = new Restaurant();

        [Fact]
        public void Name_NonEmptyValue_StoresCorrectly()
        {
            const string randomNameValue = "Komi";
            restaurant.Name = randomNameValue;
            Assert.Equal(randomNameValue, restaurant.Name);
        }

        [Fact]
        public void Name_EmptyValue_ThrowsArgumentException()
        {
            Assert.ThrowsAny<ArgumentException>(() => restaurant.Name = string.Empty);
        }

        [Fact]
        public void Reviews_DefaultValue_Empty()
        {
            // "Empty" would throw an exception if it received a null value.
            // that would result in a failed test as expected, but this way is
            // a bit cleaner.
            Assert.NotNull(restaurant.Reviews);
            Assert.Empty(restaurant.Reviews);
        }

        [Fact]
        public void Score_EmptyReviews_Null()
        {
            Assert.Null(restaurant.Score);
        }

        [Fact]
        public void Score_NullReviews_Null()
        {
            // being able to set Reviews to null is not necessarily required behavior,
            // so it's not tested, but this test will ensure that if that behavior is
            // available, then Score will behave appropriately and not throw an exception.
            try
            {
                restaurant.Reviews = null;
            }
            catch
            {
                return;
            }
            Assert.Null(restaurant.Score);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(6, 7, 8)]
        // "params" keyword lets the caller pass an arbitrary number of arguments and have them
        // put into an array automatically.
        public void Score_RestaurantHasReviews_IsAverageValue(params int[] reviewScores)
        {
            // use LINQ with a lambda expression to add reviews in one line.
            restaurant.Reviews.AddRange(reviewScores.Select(s => new Review { Score = s }));
            var average = reviewScores.Average();
            // "HasValue" and "Value" are part of the definition of nullable types.
            Assert.True(restaurant.Score.HasValue);
            // xUnit allows checking for floating-point equality allowing for imprecision.
            Assert.Equal(average, restaurant.Score.Value, precision: 6);
        }
    }
}
