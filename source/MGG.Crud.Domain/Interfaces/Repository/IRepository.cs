using System;

namespace MGG.Crud.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Create(TEntity obj);
        TEntity Read(Guid id);
        void Update(TEntity obj);
        void Delete(Guid id);
    }
}