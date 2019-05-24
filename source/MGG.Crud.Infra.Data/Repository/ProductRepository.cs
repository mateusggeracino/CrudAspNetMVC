using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Domain.Models;
using MGG.Crud.Infra.Data.Context;

namespace MGG.Crud.Infra.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MggContext context) : base(context)
        {
        }
    }
}