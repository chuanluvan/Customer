using CustomerManagement.Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Sevices.Interface
{
    public interface IFeedbackService
    {
        void AddFeedback(Feedback feedback);                     
        Feedback GetFeedbackById(int id);                        
        IEnumerable<Feedback> GetFeedbacksByCustomerId(int customerId);
        void UpdateFeedback(Feedback feedback);                
        void DeleteFeedback(int id);
    }
}
