using BusinessLayer;
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
            throw new NotImplementedException();
        }

        public Customer Read(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
