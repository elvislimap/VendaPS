using System;
using System.Linq;
using VandaPS.Infra.Data.Contexts;
using VendaPS.Domain.Entities;
using VendaPS.Domain.Interfaces.Repositories;

namespace VandaPS.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ContextEf _context;

        public ProductRepository(ContextEf context)
        {
            _context = context;
        }


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetByEan(string ean)
        {
            return _context.Products.FirstOrDefault(p => p.Ean.Equals(ean));
        }
    }
}