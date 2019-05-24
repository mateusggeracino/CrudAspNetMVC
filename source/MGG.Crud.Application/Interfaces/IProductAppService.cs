using System;
using System.Threading.Tasks;
using MGG.Crud.Application.ViewModels;

namespace MGG.Crud.Application.Interfaces
{
    public interface IProductAppService : IDisposable
    {
        void Create(ProductViewModel user);
        ProductViewModel Read(Guid id);
        void Update(ProductViewModel user);
        void Delete(Guid id);
    }
}