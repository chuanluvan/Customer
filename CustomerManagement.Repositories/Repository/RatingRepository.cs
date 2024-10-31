using CustomerManagement.Repositories.Entity;
using CustomerManagement.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CustomerManagement.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly CustomerDbContext _context;
        public RatingRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRating(int id)
        {
            var rating = await GetRatingById(id); 
            if (rating != null)
            {
                _context.Ratings.Remove(rating);      
                await _context.SaveChangesAsync();  
            }
        }

        public async Task<IEnumerable<Rating>> GetAllRatings()
        {
            return await _context.Ratings.ToListAsync();
        }

        public async Task<Rating> GetRatingById(int id)
        {
            return await _context.Ratings.FindAsync(id);
        }


        public async Task UpdateRating(Rating rating)
        {
            _context.Ratings.Update(rating);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Rating>> GetRatingsByCustomerId(int customerId)
        {
            return await _context.Ratings.Where(r => r.CustomerId == customerId).ToListAsync();
        }

    }
}
