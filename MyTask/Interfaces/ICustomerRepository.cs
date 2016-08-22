using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerRepository
    {
        bool Create(Customer customer);
        bool Edit(Customer customer);
        bool Delete(int customerID);
        List<Customer> GetAll();
        Customer GetByID(int customerID);
    }
}
