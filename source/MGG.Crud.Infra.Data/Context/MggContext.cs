using System.Data.Entity;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Infra.Data.Context
{
    public class MggContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}