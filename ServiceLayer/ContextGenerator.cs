using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ContextGenerator
    {
        private static ColetoDBContext dbContext;
        private static AutoContext autoContext;
        private static SaloniContext saloniContext;
        private static CustomerContext customerContext;

        public static ColetoDBContext GetDbContext()
        {
            if (dbContext == null)
            {
                SetDbContext();
            }
            return dbContext;
        }

        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
            dbContext = new ColetoDBContext();
        }

        public static AutoContext GetAutoContext()
        {
            if (autoContext == null)
            {
                SetAutoContext();
            }
            return autoContext;
        }

        private static void SetAutoContext()
        {
            autoContext = new AutoContext(GetDbContext());
        }

        public static SaloniContext GetSaloniContext()
        {
            if (saloniContext == null)
            {
                SetSaloniContext();
            }
            return saloniContext;
        }

        private static void SetSaloniContext()
        {
            saloniContext = new SaloniContext(GetDbContext());
        }

        public static CustomerContext GetCustomerContext()
        {
            if (customerContext == null)
            {
                SetCustomerContext();
            }
            return customerContext;
        }

        private static void SetCustomerContext()
        {
            customerContext = new CustomerContext(GetDbContext());
        }

    }
}
