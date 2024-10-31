using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repositories.Entity
{
    public class Rating
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } 
        public int Score { get; set; }     
        public string Comment { get; set; } 
        public Customer Customer { get; set; } 
    }
}