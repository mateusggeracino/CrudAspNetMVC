using System;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Domain.Interfaces.Services
{
    public interface IProductService : IDisposable
    {
        void Create(Product user);
        Product Read(Guid id);
        void Update(Product user);
        void Delete(Guid id);
    }
}