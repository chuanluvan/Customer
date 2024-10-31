using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories.Entity
{
    public class Feedback
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
    }
}
