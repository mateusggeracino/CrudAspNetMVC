using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MGG.Crud.Application.ViewModels;

namespace MGG.Crud.Application.Interfaces
{
    public interface IProductAppService : IDisposable
    {
        ProductViewModel Create(ProductViewModel user);
        ProductViewModel Read(Guid id);
        ProductViewModel Update(ProductViewModel user);
        void Delete(Guid id);
        IEnumerable<ProductViewModel> GetAll();
    }
}