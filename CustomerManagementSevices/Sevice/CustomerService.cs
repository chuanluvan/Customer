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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _repository.GetAllCustomers();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _repository.GetCustomerById(id);
        }

        public async Task AddCustomer(Customer customer)
        {
            await _repository.AddCustomer(customer);
        }

        public async Task UpdateCustomer(Customer customer)
        {
            await _repository.UpdateCustomer(customer);
        }

        public async Task DeleteCustomer(int id)
        {
            await _repository.DeleteCustomer(id);
        }
    }
}
