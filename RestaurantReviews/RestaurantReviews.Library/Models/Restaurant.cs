using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReviews.Library.Models
{
    /// <summary>
    /// A restaurant object, having a name, a collection of its reviews,
    /// and an overall score based on those reviews.
    /// </summary>
    public class Restaurant
    {
        // backing field for the "Name" property.
        // necessary to define this to be able to add validation to the setter.
        private string _name;

        /// <summary>
        /// The restaurant's ID. Zero indicates a missing value.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The restaurant's name. Must not be empty.
        /// </summary>
        public string Name
        {
            // expression-body syntax for accessing the backing field.
            // equivalent to "get { return _name; }"
            get => _name;
            set
            {
                // "value" is the value passed to the setter.
                if (value.Length == 0)
                {
                    // good practice to provide useful messages when throwing exceptions,
                    // as well as the name of the relevant parameter if applicable.
                    throw new ArgumentException("Name must not be empty.", nameof(value));
                }
                _name = value;
            }
        }

        /// <summary>
        /// The reviews of this restaurant.
        /// </summary>
        /// <remarks>
        /// Depends on the concrete "List" to simplify serialization.
        /// This is given a default value of an empty list so the caller doesn't need to check
        /// if the list is null and create it himself.
        /// </remarks>
        public List<Review> Reviews { get; set; } = new List<Review>();

        /// <summary>
        /// This restaurant's score, calculated as the average of its reviews' scores,
        /// or null if there are no reviews.
        /// </summary>
        /// <remarks>
        /// "double?" is equivalent to "Nullable<double>". This is a way to allow value types
        /// to have null values when it seems appropriate. When there are no reviews, it is
        /// more accurate to say the restaurant has no score than that it has a score of 0 or
        /// any other number, and returning null seems better than throwing an
        /// InvalidOperationException.
        /// XmlSerializer will not serialize this property because it has no setter.
        /// </remarks>
        public double? Score
        {
            get
            {
                // the "?." operator will return null if the left-hand side is null, but otherwise
                // return its member according to the right-hand side (as a nullable type if it is
                // a value type).
                // all comparisons involving null return false except "!=".
                if (Reviews?.Count > 0)
                {
                    // use LINQ with a lambda expression to calculate the average.
                    return Reviews.Average(r => r.Score);
                }
                return null;
            }
        }
    }
}
