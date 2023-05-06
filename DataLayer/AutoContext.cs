using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class AutoContext : IDB<Auto, int>
    {
        AutoContext dbContext;
        public AutoContext(ColetoDBContext dbContext_)
        {
            this.dbContext = dbContext_;
        }

        public void Create(Auto item)
        {
            try
            {
                dbContext.Autos.Add(item);
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
                Auto customerFromDb = Read(key);
                dbContext.Auto.Remove(customerFromDb);
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
                return dbContext.Autos.Find(key);
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
                return dbContext.Autos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Customer item)
        {
            try
            {
                dbContext.Autos.Update(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
