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
        ColetoDBContext dbContext;
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
                Auto autoFromDb = Read(key);
                dbContext.Autos.Remove(autoFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Auto Read(int key)
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

        public IEnumerable<Auto> ReadAll()
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

        public void Update(Auto item)
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
