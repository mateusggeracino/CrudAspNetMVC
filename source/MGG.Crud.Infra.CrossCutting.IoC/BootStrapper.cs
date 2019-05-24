using MGG.Crud.Application.Interfaces;
using MGG.Crud.Application.Services;
using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Domain.Interfaces.Services;
using MGG.Crud.Domain.Services;
using MGG.Crud.Infra.Data.Context;
using MGG.Crud.Infra.Data.Repository;
using MGG.Crud.Infra.Data.UoW;
using SimpleInjector;

namespace MGG.Crud.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);

            container.Register<IProductService, ProductService>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            container.Register<IProductAppService, ProductAppService>(Lifestyle.Scoped);

            container.Register<MggContext>(Lifestyle.Scoped);
        }
    }
}