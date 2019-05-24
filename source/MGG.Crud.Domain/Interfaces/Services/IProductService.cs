using System;
using System.Collections.Generic;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Domain.Interfaces.Services
{
    public interface IProductService : IDisposable
    {
        Product Create(Product user);
        Product Read(Guid id);
        Product Update(Product user);
        void Delete(Guid id);
        IEnumerable<Product> GetAll();
    }
}