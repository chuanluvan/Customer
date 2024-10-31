using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();

        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
