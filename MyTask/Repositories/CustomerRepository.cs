using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
using Interfaces;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private Database db = new Database();

        public bool Create(Customer customer)
        {
            bool status = false;
            if(customer != null)
            {
                customer.DateCreated = DateTime.Now;
                db.Customer.Add(customer);
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Edit(Customer customer)
        {
            bool status = false;
            if(customer != null)
            {
                Customer dbCustomer = db.Customer.FirstOrDefault(p => p.ID == customer.ID);
                db.Entry(dbCustomer).CurrentValues.SetValues(customer);
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Delete(int CustomerID)
        {
            bool status = false;
            Customer dbCustomer = db.Customer.FirstOrDefault(c => c.ID == CustomerID);
            if(dbCustomer != null)
            {
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }

        public Customer GetByID(int customerID)
        {
            return db.Customer.FirstOrDefault(c => c.ID == customerID);
        }
    }
}
