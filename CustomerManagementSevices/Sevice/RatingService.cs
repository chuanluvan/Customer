using CustomerManagement.Repositories.Entity;
using CustomerManagement.Repositories.Interface;
using CustomerManagement.Sevices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Sevices.Sevice
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task AddRating(Rating rating)
        {
            await _ratingRepository.AddRating(rating);
        }

        public async Task DeleteRating(int id)
        {
            await _ratingRepository.DeleteRating(id);
        }

        public async Task<Rating> GetRatingById(int id)
        {
            return await _ratingRepository.GetRatingById(id);
        }

        public async Task<IEnumerable<Rating>> GetRatingsByCustomerId(int customerId)
        {
            return await _ratingRepository.GetRatingsByCustomerId(customerId);
        }

        public async Task UpdateRating(Rating rating)
        {
            await _ratingRepository.UpdateRating(rating);
        }
    }
}
