using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Infra.Data.Context;

namespace MGG.Crud.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected MggContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(MggContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public void Create(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public TEntity Read(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Update(TEntity obj)
        {
            DbSet.AddOrUpdate(obj);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(Read(id));
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}