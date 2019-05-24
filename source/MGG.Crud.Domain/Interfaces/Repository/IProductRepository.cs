using System.Collections.Generic;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Domain.Interfaces.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAll();
    }
}