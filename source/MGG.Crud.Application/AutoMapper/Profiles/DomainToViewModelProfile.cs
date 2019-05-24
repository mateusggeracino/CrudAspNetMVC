using AutoMapper;
using MGG.Crud.Application.ViewModels;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Application.AutoMapper.Profiles
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}