using System;
using RestaurantReviews.Library.Models;
using Xunit;

namespace RestaurantReviews.Testing.Library.Models
{
    public class ReviewTest
    {
        readonly Review review = new Review();

        [Fact]
        public void ReviewerName_NonEmptyValue_StoresCorrectly()
        {
            const string randomReviewerNameValue = "Al Gore";
            review.ReviewerName = randomReviewerNameValue;
            Assert.Equal(randomReviewerNameValue, review.ReviewerName);
        }

        [Fact]
        public void ReviewerName_EmptyValue_ThrowsArgumentException()
        {
            Assert.ThrowsAny<ArgumentException>(() => review.ReviewerName = string.Empty);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(10)]
        public void Score_ValueBetween0And10_StoresCorrectly(int scoreValue)
        {
            review.Score = scoreValue;
            Assert.Equal(scoreValue, review.Score);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(11)]
        public void Score_ValueNotBetween0And10_ThrowsArgumentException(int scoreValue)
        {
            Assert.ThrowsAny<ArgumentException>(() => review.Score = scoreValue);
        }

        // being able to store null values is not necessarily required behavior
        [Theory]
        [InlineData("Perfect")]
        [InlineData("")]
        public void Text_NonNullValue_StoresCorrectly(string textValue)
        {
            review.Text = textValue;
            Assert.Equal(textValue, review.Text);
        }
    }
}
