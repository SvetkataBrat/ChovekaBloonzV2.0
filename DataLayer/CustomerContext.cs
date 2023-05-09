using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerContext : IDB<Customer, int>
    {
        ColetoDBContext dBContext;

        public CustomerContext(ColetoDBContext dBContext_)
        {
            this.dBContext = dBContext_;
        }

        public void Create(Customer customer)
        {
            try
            {
                dBContext.Customers.Add(customer);
                dBContext.SaveChanges();
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
                Customer custonerFromDB = Read(key);
                dBContext.Customers.Remove(custonerFromDB);
                dBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                return dBContext.Customers.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Customer> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                return dBContext.Customers.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Customer item, bool useNavigationalProperties = false)
        {
            try
            {
                dBContext.Customers.Update(item);
                dBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
