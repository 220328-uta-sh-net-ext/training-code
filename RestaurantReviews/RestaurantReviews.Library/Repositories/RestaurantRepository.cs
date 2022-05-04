using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantReviews.Library.Models;

namespace RestaurantReviews.Library.Repositories
{
    /// <summary>
    /// A repository managing data access for restaurant objects and their review members.
    /// </summary>
    public class RestaurantRepository
    {
        private readonly ICollection<Restaurant> _data;

        /// <summary>
        /// Initializes a new restaurant repository given a suitable restaurant data source.
        /// </summary>
        /// <param name="data">The data source</param>
        public RestaurantRepository(ICollection<Restaurant> data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Get all restaurants with deferred execution.
        /// </summary>
        /// <returns>The collection of restaurants</returns>
        public IEnumerable<Restaurant> GetRestaurants(string search = null)
        {
            if (search == null)
            {
                foreach (var item in _data)
                {
                    yield return item;
                }
            }
            else
            {
                foreach (var item in _data.Where(r => r.Name.Contains(search)))
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        /// Get a restaurants by ID.
        /// </summary>
        /// <returns>The restaurant</returns>
        public Restaurant GetRestaurantById(int id)
        {
            return _data.First(r => r.Id == id);
        }

        /// <summary>
        /// Add a restaurant, including any associated reviews.
        /// </summary>
        /// <param name="restaurant">The restaurant</param>
        public void AddRestaurant(Restaurant restaurant)
        {
            if (_data.Any(r => r.Id == restaurant.Id))
            {
                throw new InvalidOperationException($"Restaurant with ID {restaurant.Id} already exists.");
            }
            _data.Add(restaurant);
        }

        /// <summary>
        /// Delete a restaurant by ID. Any reviews associated to it will not be deleted.
        /// </summary>
        /// <param name="restaurantId">The ID of the restaurant</param>
        public void DeleteRestaurant(int restaurantId)
        {
            _data.Remove(_data.First(r => r.Id == restaurantId));
        }

        /// <summary>
        /// Update a restaurant as well as its reviews.
        /// </summary>
        /// <param name="restaurant">The restaurant with changed values</param>
        public void UpdateRestaurant(Restaurant restaurant)
        {
            DeleteRestaurant(restaurant.Id);
            AddRestaurant(restaurant);
        }

        /// <summary>
        /// Add a review and associate it with a restaurant.
        /// </summary>
        /// <param name="review">The review</param>
        /// <param name="restaurant">The restaurant</param>
        public void AddReview(Review review, Restaurant restaurant)
        {
            restaurant.Reviews.Add(review);
        }

        /// <summary>
        /// Delete a review by ID.
        /// </summary>
        /// <param name="reviewId">The ID of the review</param>
        public void DeleteReview(int reviewId)
        {
            var restaurant = _data.First(x => x.Reviews.Any(y => y.Id == reviewId));
            restaurant.Reviews.Remove(restaurant.Reviews.First(y => y.Id == reviewId));
        }

        /// <summary>
        /// Update a review.
        /// </summary>
        /// <param name="review">The review with changed values</param>
        public void UpdateReview(Review review)
        {
            var restaurant = _data.First(x => x.Reviews.Any(y => y.Id == review.Id));
            var index = restaurant.Reviews.IndexOf(restaurant.Reviews.First(y => y.Id == review.Id));
            restaurant.Reviews[index] = review;
        }
    }
}
