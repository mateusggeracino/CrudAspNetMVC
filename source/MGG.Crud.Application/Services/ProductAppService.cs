using System;
using AutoMapper;
using MGG.Crud.Application.Interfaces;
using MGG.Crud.Application.ViewModels;
using MGG.Crud.Domain.Interfaces.Services;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _userService;

        public ProductAppService(IProductService userService)
        {
            _userService = userService;
        }

        public void Create(ProductViewModel userViewModel)
        {
            var user = Mapper.Map<Product>(userViewModel);
            _userService.Create(user);
        }

        public ProductViewModel Read(Guid id)
        {
            return Mapper.Map<ProductViewModel>(_userService.Read(id));
        }

        public void Update(ProductViewModel userViewModel)
        {
            var user = Mapper.Map<Product>(userViewModel);
            _userService.Update(user);
        }

        public void Delete(Guid id)
        {
            _userService.Delete(id);
        }

        public void Dispose()
        {
            _userService.Dispose();
        }
    }
}