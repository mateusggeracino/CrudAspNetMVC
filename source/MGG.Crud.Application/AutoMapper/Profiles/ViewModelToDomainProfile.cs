using AutoMapper;
using MGG.Crud.Application.ViewModels;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Application.AutoMapper.Profiles
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}