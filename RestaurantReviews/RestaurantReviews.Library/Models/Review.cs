using System;

namespace RestaurantReviews.Library.Models
{
    /// <summary>
    /// A review of a restaurant, having a reviewer name, a score, and some text.
    /// </summary>
    /// <remarks>
    /// This class doesn't contain a reference to its own restaurant, partly to
    /// simplify serialization (which has trouble with circular references), and
    /// partly because it would be redundant data without a good justification.
    /// </remarks>
    public class Review
    {
        private int? _score;
        private string _reviewerName;

        /// <summary>
        /// The review's ID. Zero indicates a missing value.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the reviewer.
        /// </summary>
        public string ReviewerName
        {
            get => _reviewerName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Reviewer name must not be empty.", nameof(value));
                }
                _reviewerName = value;
            }
        }

        /// <summary>
        /// The score of the review. Must be between 0 and 10.
        /// </summary>
        public int? Score
        {
            get => _score;
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException($"Score ${value} must be between 0 and 10.",
                        nameof(value));
                }
                _score = value;
            }
        }

        /// <summary>
        /// The text of the review.
        /// </summary>
        public string Text { get; set; }
    }
}