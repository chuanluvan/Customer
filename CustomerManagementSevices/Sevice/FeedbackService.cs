using CustomerManagement.Repositories.Entity;
using CustomerManagement.Sevices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Sevices.Sevice
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackService _feedbackService;
        public FeedbackService(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public void AddFeedback(Feedback feedback)
        {
            _feedbackService.AddFeedback(feedback);
        }

        public void DeleteFeedback(int id)
        {
            _feedbackService.DeleteFeedback(id);
        }

        public Feedback GetFeedbackById(int id)
        {
            return _feedbackService.GetFeedbackById(id);
        }

        public IEnumerable<Feedback> GetFeedbacksByCustomerId(int customerId)
        {
            return _feedbackService.GetFeedbacksByCustomerId(customerId);
        }

        public void UpdateFeedback(Feedback feedback)
        {
            _feedbackService.UpdateFeedback(feedback);
        }
    }
}
