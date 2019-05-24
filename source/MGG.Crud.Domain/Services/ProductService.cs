using System;
using System.Collections.Generic;
using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Domain.Interfaces.Services;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Create(Product product)
        {
            if (!product.IsValid()) return product;

            _productRepository.Create(product);
            return product;
        }

        public Product Read(Guid id)
        {
            return _productRepository.Read(id);
        }

        public Product Update(Product product)
        {
            if (!product.IsValid()) return product;

            _productRepository.Update(product);
            return product;
        }

        public void Delete(Guid id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Dispose()
        {
            _productRepository.Dispose();
        }
    }
}