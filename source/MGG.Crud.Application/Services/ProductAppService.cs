using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MGG.Crud.Application.Interfaces;
using MGG.Crud.Application.ViewModels;
using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Domain.Interfaces.Services;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _productService;
        private readonly IUnitOfWork _uow;

        public ProductAppService(IProductService productService, IUnitOfWork uow)
        {
            _productService = productService;
            _uow = uow;
        }

        public ProductViewModel Create(ProductViewModel productViewModel)
        {
            productViewModel.RegisterDate = DateTime.Now;
            var productEntity = Mapper.Map<Product>(productViewModel);
            productViewModel = Mapper.Map<ProductViewModel>(_productService.Create(productEntity));

            if (productViewModel.ValidationResult.Errors.Any()) return productViewModel;

            _uow.Commit();
            return productViewModel;
        }

        public ProductViewModel Read(Guid id)
        {
            return Mapper.Map<ProductViewModel>(_productService.Read(id));
        }

        public ProductViewModel Update(ProductViewModel productViewModel)
        {
            var product = Mapper.Map<Product>(productViewModel);
            var productEntity = _productService.Update(product);
            return Mapper.Map<ProductViewModel>(productEntity);
        }

        public void Delete(Guid id)
        {
            _productService.Delete(id);
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<ProductViewModel>>(_productService.GetAll());
        }

        public void Dispose()
        {
            _productService.Dispose();
        }
    }
}