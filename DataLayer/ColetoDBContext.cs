using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ColetoDBContext : DbContext
    {
        public ColetoDBContext()
        {

        }

        public ColetoDBContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Svetkata - Server=TIMI-PC\MSSQLSERVER03;Database=MusicDB;Trusted_Connection=True;Encrypt=false" -Provider "Microsoft.EntityFrameworkCore.SqlServer
            // Ico - 
            // Lucho -


            optionsBuilder.UseSqlServer("Server=DESKTOP-BI5DLAH\\SQLEXPRESS;Database=ColetoV2;Trusted_Connection=True;Encrypt=false\" -Provider \"Microsoft.EntityFrameworkCore.SqlServer");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Auto> Autos { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Saloni> Salons { get; set; }
    }
}
