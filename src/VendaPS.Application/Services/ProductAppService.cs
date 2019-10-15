using VendaPS.Application.Interfaces;
using VendaPS.Domain.Entities;
using VendaPS.Domain.Interfaces.Repositories;
using VendaPS.Domain.Validations;
using VendaPS.Domain.ValueObjects;

namespace VendaPS.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public Result Add(Product product)
        {
            if (!product.IsValid(out var validationErrors))
                return new Result(validationErrors: validationErrors);

            _productRepository.Add(product);

            return new Result(product);
        }

        public Result GetByEan(string ean)
        {
            return new Result(_productRepository.GetByEan(ean));
        }
    }
}