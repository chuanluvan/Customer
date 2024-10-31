using CustomerManagement.Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories.Interface
{
    public interface IRatingRepository
    {
        Task<IEnumerable<Rating>> GetAllRatings();
        Task<Rating> GetRatingById(int id);
        Task AddRating(Rating rating);
        Task UpdateRating(Rating rating);
        Task DeleteRating(int id);
        Task<IEnumerable<Rating>> GetRatingsByCustomerId(int customerId);
    }
}
