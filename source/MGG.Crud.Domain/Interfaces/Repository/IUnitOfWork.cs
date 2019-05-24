using System;

namespace MGG.Crud.Domain.Interfaces.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}