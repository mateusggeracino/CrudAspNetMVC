using AutoMapper;
using MGG.Crud.Application.AutoMapper.Profiles;

namespace MGG.Crud.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelProfile>();
                x.AddProfile<ViewModelToDomainProfile>();
            });
        }
    }
}