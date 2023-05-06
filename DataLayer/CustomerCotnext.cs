using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerCotnext : IDB<Customer, int>
    {

        ColetoDBContext dbContext;
        public CustomerCotnext(ColetoDBContext dbContext_)
        {
            this.dbContext = dbContext_;
        }

        public void Create(Customer customer)
        {
            try
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int key)
        {
            try
            {
                Customer customerFromDb = Read(key);
                dbContext.Customers.Remove(customerFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer Read(int key)
        {
            try
            {
                return dbContext.Customers.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                return dbContext.Customers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Customer customer)
        {
            try
            {
                dbContext.Customers.Update(customer);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
