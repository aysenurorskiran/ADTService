using System.Collections.Generic;
using ADTServis.DAL.Repositories;
using ADTServis.Entities;

namespace ADTServis.BLL
{
    public class CustomerService
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public List<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }
    }
}


