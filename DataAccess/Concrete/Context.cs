using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BB\\SQLEXPRESS;database=SampleDb;trusted_connection=true;");
        }

        public DbSet<SampleEntity> SampleEntites { get; set; }
        public DbSet<UuidEntity>  UuidEntities { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}
    }
}
