using CustomerManagement.Repositories.Entity;
using CustomerManagement.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly CustomerDbContext _context;        

        public FeedbackRepository(CustomerDbContext context)
        {
            _context = context;
        }

        public void AddFeedback(Feedback feedback)
        {
            _context.Feedbacks.Add(feedback);                  
            _context.SaveChanges();
        }

        public void DeleteFeedback(int id)
        {
            var feedback = GetFeedbackById(id);
            if (feedback != null)
            {
                _context.Feedbacks.Remove(feedback);             
                _context.SaveChanges();                      
            }
        }

        public Feedback GetFeedbackById(int id)
        {
            return _context.Feedbacks.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Feedback> GetFeedbacksByCustomerId(int customerId)
        {
            return _context.Feedbacks.Where(f => f.CustomerId == customerId).ToList();
        }

        public void UpdateFeedback(Feedback feedback)
        {
            _context.Feedbacks.Update(feedback);           
            _context.SaveChanges();
        }
    }
}
