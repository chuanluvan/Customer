using CustomerManagement.Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Sevices.Interface
{
    public interface IRatingService
    {
        Task AddRating(Rating rating);                            
        Task<Rating> GetRatingById(int id);                            
        Task<IEnumerable<Rating>> GetRatingsByCustomerId(int customerId); 
        Task UpdateRating(Rating rating);                         
        Task DeleteRating(int id);
    }
}
