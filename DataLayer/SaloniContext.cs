using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SaloniContext : IDB<Saloni, int>
    {
        ColetoDBContext dbContext;
        public SaloniContext(ColetoDBContext dbContext_)
        {
            this.dbContext = dbContext_;
        }

        public void Create(Saloni item)
        {
            try
            {
                dbContext.Salons.Add(item);
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
                Saloni salonFromDb = Read(key);
                dbContext.Salons.Remove(salonFromDb);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Saloni Read(int key, bool useNavigationalProperties = false)
        {
            try
            {
                return dbContext.Salons.Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Saloni> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                return dbContext.Salons.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Saloni item, bool useNavigationalProperties = false)
        {
            try
            {
                dbContext.Salons.Update(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
