using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using MGG.Crud.Domain.Models;
using MGG.Crud.Infra.Data.Mapping;

namespace MGG.Crud.Infra.Data.Context
{
    public class MggContext : DbContext
    {
        public MggContext() : base("DefaultConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}