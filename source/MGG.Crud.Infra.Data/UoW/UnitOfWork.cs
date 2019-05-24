using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Infra.Data.Context;

namespace MGG.Crud.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        protected MggContext Db;

        public UnitOfWork(MggContext db)
        {
            Db = db;
        }

        public bool Commit()
        {
            return Db.SaveChanges() > 0;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}