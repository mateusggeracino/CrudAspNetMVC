using System;
using MGG.Crud.Domain.Interfaces.Repository;
using MGG.Crud.Domain.Interfaces.Services;
using MGG.Crud.Domain.Models;

namespace MGG.Crud.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _userRepository;

        public ProductService(IProductRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(Product user)
        {
            _userRepository.Create(user);
        }

        public Product Read(Guid id)
        {
            return _userRepository.Read(id);
        }

        public void Update(Product user)
        {
            _userRepository.Update(user);
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }
    }
}